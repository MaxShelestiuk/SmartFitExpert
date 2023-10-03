import clips

DEFTEMPLATE_STRING = """
(deftemplate exercise
   (slot id)
   (slot name)
   (slot target_muscle_group)
   (slot priority)
   (slot jointness)
   (multislot support_muscle_groups)
   (multislot equipment))

(deftemplate user_profile
   (slot name)
   (slot gender)
   (slot weight)
   (slot height)
   (slot age)
   (slot restriction)
   (slot available_days)
   (slot goal))

(deftemplate health_indicator
   (slot parameterName)
   (slot parameterValue))

(deftemplate bmi_formal
   (slot formal_name))

(deftemplate recommendation
   (slot bad_practice)
   (slot weekly_plan_id))

(deftemplate daily_plan
   (slot id_d)
   (slot age_group)
   (slot goal)
   (slot days)
   (slot day_n)
   (slot exersice_organization_type)
   (multislot exercises_id))

(deftemplate weekly_plan
   (slot id_w)
   (slot days)
   (slot rest_days)
   (slot week_plan_type)
   (multislot daily_plans_id))
"""

DEFRULE_STRING_HEALTH = """
(defrule AgeGroupYoung
   (user_profile (age ?a&:(>= ?a 18)&:(<= ?a 23)))
   =>
   (assert (age_group Young))
)
(defrule AgeGroupModerate
   (user_profile (age ?a&:(>= ?a 24)&:(<= ?a 45)))
   =>
   (assert (age_group Moderate))
)
(defrule AgeGroupOld
   (user_profile (age ?a&:(>= ?a 46)))
   =>
   (assert (age_group Old))
)

(defrule CalculateMaleBMR
   (user_profile (weight ?w) (height ?h) (age ?a) (gender male))
   =>
   (assert (health_indicator(parameterName BMR) (parameterValue =(- (+ (+ 66.5 (* 13.75 ?w)) (* 5.003 ?h)) (* 6.75 ?a))))))

(defrule CalculateFemaleBMR
   (user_profile (weight ?w) (height ?h) (age ?a) (gender female))
   =>
   (assert (health_indicator(parameterName BMR) (parameterValue =(- (+ (+ 655.1 (* 9.563 ?w)) (* 1.85 ?h)) (* 4.676 ?a))))))

(defrule CalculateBMI
   (user_profile (weight ?w) (height ?h))
   =>
   (assert (health_indicator(parameterName BMI) (parameterValue =(/ ?w (** (/ ?h 100) 2))))))

(defrule BMIOptimal
   (health_indicator(parameterName BMI)(parameterValue ?bmi&:(>= ?bmi 18.5)&:(<= ?bmi 24.9)))
   =>
   (assert (bmi_formal (formal_name Optimal))))

(defrule BMICritical
   (health_indicator(parameterName BMI)(parameterValue ?bmi&:(>= ?bmi 40)|:(<= ?bmi 13)))
   =>
   (assert (bmi_formal (formal_name Critical))))

(defrule BMIUnderWeight
   (health_indicator(parameterName BMI)(parameterValue ?bmi&:(< ?bmi 18.5)))
   =>
   (assert (bmi_formal (formal_name UnderWeight))))

(defrule BMIOverWeight
   (health_indicator(parameterName BMI)(parameterValue ?bmi&:(>= ?bmi 25)&:(<= ?bmi 29.9)))
   =>
   (assert (bmi_formal (formal_name OverWeight))))

(defrule BMIObese1
   (health_indicator(parameterName BMI)(parameterValue ?bmi&:(>= ?bmi 30)&:(<= ?bmi 34.9)))
   =>
   (assert (bmi_formal (formal_name Obese1))))

(defrule BMIObese2
   (health_indicator(parameterName BMI)(parameterValue ?bmi&:(>= ?bmi 35)&:(<= ?bmi 39.9)))
   =>
   (assert (bmi_formal (formal_name Obese2))))
"""

DEFRULE_STRING_MUSCLE_GAIN = """
(defrule UnderWeight_Fat_Loss
   (bmi_formal(formal_name undereight))
   (user_profile(goal fat_loss))
   =>
   (assert (recomendation (bad_practice "Considering your BMI (UnderWeight) we recommend to change your goal for Muscle gain and follow next training program:")
   (weekly_plan_id ?*id*)))
   (bind ?*id*=(+ ?*id* 1))
)

(defrule Young_LimitDays
   (user_profile(available_days ?days&:(= ?days 1)|:(= ?days 7)))
   (user_profile(age ?age&:(>= ?age 18)&:(<= ?age 23)))
   =>
   (assert (recomendation (bad_practice "Considering your Age we recommend to change number of training days for 2-6 days")
   (weekly_plan_id 0)))
)

(defrule Week_Plan_Muscle_gain_1days
   (user_profile(available_days ?days&:(= ?days 1))(goal Muscle_gain))
   (age_group ?ag)
   (daily_plan(days 1)(goal Muscle_gain)(age_group ?ag)(exersice_organization_type Circullar)(day_n 1)(id_d ?id1))
   =>
   (assert (weekly_plan(id_w ?*id*)(days 1)(rest_days d1)(week_plan_type Full_Body)(daily_plans_id ?id1)))
   (bind ?*id*=(+ ?*id* 1))
)
(defrule Week_Plan_Muscle_gain_2days
   (user_profile(available_days ?days&:(= ?days 2))(goal Muscle_gain))
   (age_group ?ag)
   (daily_plan(days 2)(goal Muscle_gain)(age_group ?ag)(exersice_organization_type Circullar)(day_n 1)(id_d ?id1))
   (daily_plan(days 2)(goal Muscle_gain)(age_group ?ag)(exersice_organization_type Circullar)(day_n 2)(id_d ?id2))
   =>
   (assert (weekly_plan(id_w ?*id*)(days 2)(rest_days d1r23d2)(week_plan_type Full_Body)(daily_plans_id ?id1 ?id2)))
   (bind ?*id*=(+ ?*id* 1))
)

(defrule Week_Plan_Muscle_gain_3days
   (user_profile(available_days ?days&:(= ?days 3))(goal Muscle_gain))
   (age_group ?ag)
   (daily_plan(days 3)(goal Muscle_gain)(age_group ?ag)(exersice_organization_type Circullar)(day_n 1)(id_d ?id1))
   (daily_plan(days 3)(goal Muscle_gain)(age_group ?ag)(exersice_organization_type Circullar)(day_n 2)(id_d ?id2))
   (daily_plan(days 3)(goal Muscle_gain)(age_group ?ag)(exersice_organization_type Circullar)(day_n 3)(id_d ?id3))
   =>
   (assert (weekly_plan(id_w ?*id*)(days 3)(rest_days d1r1d2r1d3)(week_plan_type Full_Body)(daily_plans_id ?id1 ?id2 ?id3)))
   (bind ?*id*=(+ ?*id* 1))
)

(defrule Week_Plan_Muscle_gain_4days
   (user_profile(available_days ?days&:(= ?days 4))(goal Muscle_gain))
   (age_group ?ag)
   (daily_plan(days 4)(goal Muscle_gain)(age_group ?ag)(exersice_organization_type Circullar)(day_n 1)(id_d ?id1))
   (daily_plan(days 4)(goal Muscle_gain)(age_group ?ag)(exersice_organization_type Circullar)(day_n 2)(id_d ?id2))
   (daily_plan(days 4)(goal Muscle_gain)(age_group ?ag)(exersice_organization_type Circullar)(day_n 3)(id_d ?id3))
   (daily_plan(days 4)(goal Muscle_gain)(age_group ?ag)(exersice_organization_type Circullar)(day_n 4)(id_d ?id4))
   =>
   (assert (weekly_plan(id_w ?*id*)(days 4)(rest_days d1r0d2r12d3r0d4)(week_plan_type Upper_and_Lower_Body)(daily_plans_id ?id1 ?id2 ?id3 ?id4)))
   (bind ?*id*=(+ ?*id* 1))
)
(defrule Week_Plan_Muscle_gain_5days
   (user_profile(available_days ?days&:(= ?days 5))(goal Muscle_gain))
   (age_group ?ag&:(neq ?ag "Old"))
   (daily_plan(days 5)(goal Muscle_gain)(age_group ?ag)(exersice_organization_type Circullar)(day_n 1)(id_d ?id1))
   (daily_plan(days 5)(goal Muscle_gain)(age_group ?ag)(exersice_organization_type Circullar)(day_n 2)(id_d ?id2))
   (daily_plan(days 5)(goal Muscle_gain)(age_group ?ag)(exersice_organization_type Circullar)(day_n 3)(id_d ?id3))
   (daily_plan(days 5)(goal Muscle_gain)(age_group ?ag)(exersice_organization_type Circullar)(day_n 4)(id_d ?id4))
   (daily_plan(days 5)(goal Muscle_gain)(age_group ?ag)(exersice_organization_type Circullar)(day_n 5)(id_d ?id5))
   =>
   (assert (weekly_plan(id_w ?*id*)(days 5)(rest_days d1r0d2r0d3r1d4r0d5)(week_plan_type Profi_Upper_and_Lower_Body)(daily_plans_id ?id1 ?id2 ?id3 ?id4 ?id5)))
   (bind ?*id*=(+ ?*id* 1))
)
(defrule Week_Plan_Muscle_gain_6days
   (user_profile(available_days ?days&:(= ?days 6))(goal Muscle_gain))
   (age_group ?ag&:(neq ?ag "Old"))
   (daily_plan(days 6)(goal Muscle_gain)(age_group ?ag)(exersice_organization_type Circullar)(day_n 1)(id_d ?id1))
   (daily_plan(days 6)(goal Muscle_gain)(age_group ?ag)(exersice_organization_type Circullar)(day_n 2)(id_d ?id2))
   (daily_plan(days 6)(goal Muscle_gain)(age_group ?ag)(exersice_organization_type Circullar)(day_n 3)(id_d ?id3))
   (daily_plan(days 6)(goal Muscle_gain)(age_group ?ag)(exersice_organization_type Circullar)(day_n 4)(id_d ?id4))
   (daily_plan(days 6)(goal Muscle_gain)(age_group ?ag)(exersice_organization_type Circullar)(day_n 5)(id_d ?id5))
   (daily_plan(days 6)(goal Muscle_gain)(age_group ?ag)(exersice_organization_type Circullar)(day_n 6)(id_d ?id6))
   =>
   (assert (weekly_plan(id_w ?*id*)(days 6)(rest_days d1r0d2r0d3r1d4r0d5r0d6)(week_plan_type Profi_Upper_and_Lower_Body)(daily_plans_id ?id1 ?id2 ?id3 ?id4 ?id5 ?id6)))
   (bind ?*id*=(+ ?*id* 1))
)
"""

DEFRULE_STRING_FAT_LOSS = """
(defrule UnderWeight_Fat_Loss
   (bmi_formal(formal_name undereight))
   (user_profile(goal fat_loss))
   =>
   (assert (recomendation (bad_practice "Considering your BMI (UnderWeight) we recommend to change your goal for Muscle gain and follow next training program:")
   (weekly_plan_id ?*id*)))
   (bind ?*id*=(+ ?*id* 1))
)
"""

DEFRULE_STRING_GENERAL = """
(defrule Young_LimitDays
   (user_profile(available_days ?days&:(= ?days 1)|:(= ?days 7)))
   (user_profile(age ?age&:(>= ?age 18)&:(<= ?age 23)))
   =>
   (assert (recomendation (bad_practice "Considering your Age we recommend to change number of training days for 2-6 days")
   (weekly_plan_id 0)))
)
"""
environment = clips.Environment()

# define constructs
environment.build(DEFTEMPLATE_STRING)
environment.build(DEFRULE_STRING_HEALTH)
environment.build(DEFRULE_STRING_MUSCLE_GAIN)
environment.build(DEFRULE_STRING_FAT_LOSS)
environment.build(DEFRULE_STRING_GENERAL)

# retrieve the fact template
templateExercise = environment.find_template('exercise')

# assert a new fact through its template
fact = template.assert_fact(name='John',
                            surname='Doe',
                            birthdate=clips.Symbol('01/01/1970'))

# fact slots can be accessed as dictionary elements
assert fact['name'] == 'John'

# execute the activations in the agenda
environment.run()