/*
 * regulator.c
 *
 *  Created on: Jan 25, 2022
 *      Author: kubag
 * Calculation of two-position controller
 * @param[in,out] s A pointer to two-position controller parameters and history
 * @param[in] setpoint Input setpoint value
 * @param[in] measured Input measured value
 * @return Controller output value
 */

#include "regulator.h"

float32_t calculate_two_position_controller(two_position_t* controller, float32_t setpoint, float32_t measured){
	float32_t error;

	error = setpoint-measured;
	//Controller
	if(error >= controller->H/2.0) controller->u_value = controller->u_max;
	else if(error < -1*controller->H/2.0) controller->u_value = controller->u_min;
	return controller->u_value;
}

