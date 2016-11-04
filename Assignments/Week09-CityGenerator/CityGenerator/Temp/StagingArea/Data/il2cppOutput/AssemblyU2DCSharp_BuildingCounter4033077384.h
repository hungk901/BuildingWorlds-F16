#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

// System.Collections.Generic.List`1<UnityEngine.GameObject>
struct List_1_t747900261;
// UnityEngine.GameObject
struct GameObject_t3674682005;

#include "UnityEngine_UnityEngine_MonoBehaviour667441552.h"

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// BuildingCounter
struct  BuildingCounter_t4033077384  : public MonoBehaviour_t667441552
{
public:
	// System.Int32 BuildingCounter::numOfBuildings
	int32_t ___numOfBuildings_2;
	// System.Collections.Generic.List`1<UnityEngine.GameObject> BuildingCounter::allBuildingPrefabs
	List_1_t747900261 * ___allBuildingPrefabs_3;
	// UnityEngine.GameObject BuildingCounter::_myStreetmakerPrefab
	GameObject_t3674682005 * ____myStreetmakerPrefab_4;

public:
	inline static int32_t get_offset_of_numOfBuildings_2() { return static_cast<int32_t>(offsetof(BuildingCounter_t4033077384, ___numOfBuildings_2)); }
	inline int32_t get_numOfBuildings_2() const { return ___numOfBuildings_2; }
	inline int32_t* get_address_of_numOfBuildings_2() { return &___numOfBuildings_2; }
	inline void set_numOfBuildings_2(int32_t value)
	{
		___numOfBuildings_2 = value;
	}

	inline static int32_t get_offset_of_allBuildingPrefabs_3() { return static_cast<int32_t>(offsetof(BuildingCounter_t4033077384, ___allBuildingPrefabs_3)); }
	inline List_1_t747900261 * get_allBuildingPrefabs_3() const { return ___allBuildingPrefabs_3; }
	inline List_1_t747900261 ** get_address_of_allBuildingPrefabs_3() { return &___allBuildingPrefabs_3; }
	inline void set_allBuildingPrefabs_3(List_1_t747900261 * value)
	{
		___allBuildingPrefabs_3 = value;
		Il2CppCodeGenWriteBarrier(&___allBuildingPrefabs_3, value);
	}

	inline static int32_t get_offset_of__myStreetmakerPrefab_4() { return static_cast<int32_t>(offsetof(BuildingCounter_t4033077384, ____myStreetmakerPrefab_4)); }
	inline GameObject_t3674682005 * get__myStreetmakerPrefab_4() const { return ____myStreetmakerPrefab_4; }
	inline GameObject_t3674682005 ** get_address_of__myStreetmakerPrefab_4() { return &____myStreetmakerPrefab_4; }
	inline void set__myStreetmakerPrefab_4(GameObject_t3674682005 * value)
	{
		____myStreetmakerPrefab_4 = value;
		Il2CppCodeGenWriteBarrier(&____myStreetmakerPrefab_4, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
