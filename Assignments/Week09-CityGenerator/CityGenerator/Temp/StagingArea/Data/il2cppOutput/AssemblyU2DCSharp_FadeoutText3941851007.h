#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

// UnityEngine.UI.Text
struct Text_t9039225;

#include "UnityEngine_UnityEngine_MonoBehaviour667441552.h"

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// FadeoutText
struct  FadeoutText_t3941851007  : public MonoBehaviour_t667441552
{
public:
	// UnityEngine.UI.Text FadeoutText::CityNameText
	Text_t9039225 * ___CityNameText_2;
	// System.Single FadeoutText::colorAlpha
	float ___colorAlpha_3;

public:
	inline static int32_t get_offset_of_CityNameText_2() { return static_cast<int32_t>(offsetof(FadeoutText_t3941851007, ___CityNameText_2)); }
	inline Text_t9039225 * get_CityNameText_2() const { return ___CityNameText_2; }
	inline Text_t9039225 ** get_address_of_CityNameText_2() { return &___CityNameText_2; }
	inline void set_CityNameText_2(Text_t9039225 * value)
	{
		___CityNameText_2 = value;
		Il2CppCodeGenWriteBarrier(&___CityNameText_2, value);
	}

	inline static int32_t get_offset_of_colorAlpha_3() { return static_cast<int32_t>(offsetof(FadeoutText_t3941851007, ___colorAlpha_3)); }
	inline float get_colorAlpha_3() const { return ___colorAlpha_3; }
	inline float* get_address_of_colorAlpha_3() { return &___colorAlpha_3; }
	inline void set_colorAlpha_3(float value)
	{
		___colorAlpha_3 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
