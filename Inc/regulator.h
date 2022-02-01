/*
 *@file regulator.h
 *@date Jan 25, 2022
 *@author Jakub Glab
 */

#ifndef INC_REGULATOR_H_
#define INC_REGULATOR_H_

typedef float float32_t;

/*! @name Controller configuration structure */
typedef struct{
  float32_t H;
  float32_t u_min, u_max;
  float32_t u_value;
}two_position_t;


/*!
* @brief Calculation of two-position controller
* @param [in,out] controller : A pointer to two_position controller parameters and history.
* @param [in] setpoint : Reference value.
* @param [in] measured : Measured value.
* return controller output value
*/
float32_t calculate_two_position_controller(two_position_t* controller, float32_t setpoint, float32_t measured);

#endif /* INC_REGULATOR_H_ */
