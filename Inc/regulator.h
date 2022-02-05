/**
  ******************************************************************************
  * @file           : regulator.h
  * @brief          : Header for regulator.c file.
  *                   This file contains the function prototype for regulator.c file
  ******************************************************************************
  * @attention
  *
  * <h2><center>&copy; Copyright (c) 2021 STMicroelectronics.
  * All rights reserved.</center></h2>
  *
  * This software component is licensed by ST under BSD 3-Clause license,
  * the "License"; You may not use this file except in compliance with the
  * License. You may obtain a copy of the License at:
  *                        opensource.org/licenses/BSD-3-Clause
  *
  ******************************************************************************
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
