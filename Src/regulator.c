/*
 *@file regulator.c
 *@date Jan 25, 2022
 *@author Jakub Glab
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

