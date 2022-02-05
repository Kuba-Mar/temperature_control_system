/**
  ******************************************************************************
  * @file           : regulator.c
  * @brief          : This file provides code for two position controller.
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

#include "regulator.h"


/*!
 * @brief Calculation of two-position controller
 */
float32_t calculate_two_position_controller(two_position_t* controller, float32_t setpoint, float32_t measured) {
  float32_t error;

  error = setpoint-measured;
  //Controller
  if(error >= controller->H/2.0)
    controller->u_value = controller->u_max;
  else if(error < -1*controller->H/2.0)
    controller->u_value = controller->u_min;
  return controller->u_value;
}

