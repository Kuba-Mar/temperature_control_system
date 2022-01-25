/*
 * regulator.h
 *
 *  Created on: Jan 25, 2022
 *      Author: kubag
 */

#ifndef INC_REGULATOR_H_
#define INC_REGULATOR_H_

#define reg_Type regulator_Handle_TypeDef*

typedef float float32_t;

typedef struct{
	float32_t H;
	float32_t u_min, u_max;
	float32_t u_value;
}two_position_t;

float32_t calculate_two_position_controller(two_position_t* controller, float32_t setpoint, float32_t measured);

#endif /* INC_REGULATOR_H_ */
