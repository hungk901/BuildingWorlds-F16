#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

// UnityEngine.GameObject
struct GameObject_t3674682005;

#include "UnityEngine_UnityEngine_MonoBehaviour667441552.h"

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// Streetmaker
struct  Streetmaker_t2763168257  : public MonoBehaviour_t667441552
{
public:
	// UnityEngine.GameObject Streetmaker::myStreetmakerPrefab
	GameObject_t3674682005 * ___myStreetmakerPrefab_2;
	// UnityEngine.GameObject Streetmaker::myBuildingPrefab01
	GameObject_t3674682005 * ___myBuildingPrefab01_3;
	// UnityEngine.GameObject Streetmaker::myBuildingPrefab02
	GameObject_t3674682005 * ___myBuildingPrefab02_4;
	// UnityEngine.GameObject Streetmaker::tmpPrefab01
	GameObject_t3674682005 * ___tmpPrefab01_5;
	// UnityEngine.GameObject Streetmaker::tmpPrefab02
	GameObject_t3674682005 * ___tmpPrefab02_6;
	// System.Int32 Streetmaker::stepCount
	int32_t ___stepCount_7;
	// System.Int32 Streetmaker::stepCountMax
	int32_t ___stepCountMax_8;

public:
	inline static int32_t get_offset_of_myStreetmakerPrefab_2() { return static_cast<int32_t>(offsetof(Streetmaker_t2763168257, ___myStreetmakerPrefab_2)); }
	inline GameObject_t3674682005 * get_myStreetmakerPrefab_2() const { return ___myStreetmakerPrefab_2; }
	inline GameObject_t3674682005 ** get_address_of_myStreetmakerPrefab_2() { return &___myStreetmakerPrefab_2; }
	inline void set_myStreetmakerPrefab_2(GameObject_t3674682005 * value)
	{
		___myStreetmakerPrefab_2 = value;
		Il2CppCodeGenWriteBarrier(&___myStreetmakerPrefab_2, value);
	}

	inline static int32_t get_offset_of_myBuildingPrefab01_3() { return static_cast<int32_t>(offsetof(Streetmaker_t2763168257, ___myBuildingPrefab01_3)); }
	inline GameObject_t3674682005 * get_myBuildingPrefab01_3() const { return ___myBuildingPrefab01_3; }
	inline GameObject_t3674682005 ** get_address_of_myBuildingPrefab01_3() { return &___myBuildingPrefab01_3; }
	inline void set_myBuildingPrefab01_3(GameObject_t3674682005 * value)
	{
		___myBuildingPrefab01_3 = value;
		Il2CppCodeGenWriteBarrier(&___myBuildingPrefab01_3, value);
	}

	inline static int32_t get_offset_of_myBuildingPrefab02_4() { return static_cast<int32_t>(offsetof(Streetmaker_t2763168257, ___myBuildingPrefab02_4)); }
	inline GameObject_t3674682005 * get_myBuildingPrefab02_4() const { return ___myBuildingPrefab02_4; }
	inline GameObject_t3674682005 ** get_address_of_myBuildingPrefab02_4() { return &___myBuildingPrefab02_4; }
	inline void set_myBuildingPrefab02_4(GameObject_t3674682005 * value)
	{
		___myBuildingPrefab02_4 = value;
		Il2CppCodeGenWriteBarrier(&___myBuildingPrefab02_4, value);
	}

	inline static int32_t get_offset_of_tmpPrefab01_5() { return static_cast<int32_t>(offsetof(Streetmaker_t2763168257, ___tmpPrefab01_5)); }
	inline GameObject_t3674682005 * get_tmpPrefab01_5() const { return ___tmpPrefab01_5; }
	inline GameObject_t3674682005 ** get_address_of_tmpPrefab01_5() { return &___tmpPrefab01_5; }
	inline void set_tmpPrefab01_5(GameObject_t3674682005 * value)
	{
		___tmpPrefab01_5 = value;
		Il2CppCodeGenWriteBarrier(&___tmpPrefab01_5, value);
	}

	inline static int32_t get_offset_of_tmpPrefab02_6() { return static_cast<int32_t>(offsetof(Streetmaker_t2763168257, ___tmpPrefab02_6)); }
	inline GameObject_t3674682005 * get_tmpPrefab02_6() const { return ___tmpPrefab02_6; }
	inline GameObject_t3674682005 ** get_address_of_tmpPrefab02_6() { return &___tmpPrefab02_6; }
	inline void set_tmpPrefab02_6(GameObject_t3674682005 * value)
	{
		___tmpPrefab02_6 = value;
		Il2CppCodeGenWriteBarrier(&___tmpPrefab02_6, value);
	}

	inline static int32_t get_offset_of_stepCount_7() { return static_cast<int32_t>(offsetof(Streetmaker_t2763168257, ___stepCount_7)); }
	inline int32_t get_stepCount_7() const { return ___stepCount_7; }
	inline int32_t* get_address_of_stepCount_7() { return &___stepCount_7; }
	inline void set_stepCount_7(int32_t value)
	{
		___stepCount_7 = value;
	}

	inline static int32_t get_offset_of_stepCountMax_8() { return static_cast<int32_t>(offsetof(Streetmaker_t2763168257, ___stepCountMax_8)); }
	inline int32_t get_stepCountMax_8() const { return ___stepCountMax_8; }
	inline int32_t* get_address_of_stepCountMax_8() { return &___stepCountMax_8; }
	inline void set_stepCountMax_8(int32_t value)
	{
		___stepCountMax_8 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
