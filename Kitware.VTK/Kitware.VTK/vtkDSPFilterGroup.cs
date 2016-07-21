using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkDSPFilterGroup : vtkObject
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkDSPFilterGroup";

		public new static readonly string MRClassNameKey;

		static vtkDSPFilterGroup()
		{
			vtkDSPFilterGroup.MRClassNameKey = "class vtkDSPFilterGroup";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkDSPFilterGroup.MRClassNameKey, Type.GetType("Kitware.VTK.vtkDSPFilterGroup"));
		}

		public vtkDSPFilterGroup(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkDSPFilterGroup_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkDSPFilterGroup New()
		{
			vtkDSPFilterGroup result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDSPFilterGroup.vtkDSPFilterGroup_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDSPFilterGroup)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkDSPFilterGroup() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkDSPFilterGroup.vtkDSPFilterGroup_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkDSPFilterGroup_AddFilter_01(HandleRef pThis, HandleRef filter);

		public void AddFilter(vtkDSPFilterDefinition filter)
		{
			vtkDSPFilterGroup.vtkDSPFilterGroup_AddFilter_01(base.GetCppThis(), (filter == null) ? default(HandleRef) : filter.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkDSPFilterGroup_AddInputVariableInstance_02(HandleRef pThis, string a_name, int a_timestep, HandleRef a_data);

		public void AddInputVariableInstance(string a_name, int a_timestep, vtkFloatArray a_data)
		{
			vtkDSPFilterGroup.vtkDSPFilterGroup_AddInputVariableInstance_02(base.GetCppThis(), a_name, a_timestep, (a_data == null) ? default(HandleRef) : a_data.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkDSPFilterGroup_Copy_03(HandleRef pThis, HandleRef other);

		public void Copy(vtkDSPFilterGroup other)
		{
			vtkDSPFilterGroup.vtkDSPFilterGroup_Copy_03(base.GetCppThis(), (other == null) ? default(HandleRef) : other.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkDSPFilterGroup_GetCachedInput_04(HandleRef pThis, int a_whichFilter, int a_whichTimestep, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkFloatArray GetCachedInput(int a_whichFilter, int a_whichTimestep)
		{
			vtkFloatArray vtkFloatArray = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDSPFilterGroup.vtkDSPFilterGroup_GetCachedInput_04(base.GetCppThis(), a_whichFilter, a_whichTimestep, ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkFloatArray = (vtkFloatArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkFloatArray.Register(null);
				}
			}
			return vtkFloatArray;
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkDSPFilterGroup_GetCachedOutput_05(HandleRef pThis, int a_whichFilter, int a_whichTimestep, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkFloatArray GetCachedOutput(int a_whichFilter, int a_whichTimestep)
		{
			vtkFloatArray vtkFloatArray = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDSPFilterGroup.vtkDSPFilterGroup_GetCachedOutput_05(base.GetCppThis(), a_whichFilter, a_whichTimestep, ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkFloatArray = (vtkFloatArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkFloatArray.Register(null);
				}
			}
			return vtkFloatArray;
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkDSPFilterGroup_GetFilter_06(HandleRef pThis, int a_whichFilter, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkDSPFilterDefinition GetFilter(int a_whichFilter)
		{
			vtkDSPFilterDefinition vtkDSPFilterDefinition = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDSPFilterGroup.vtkDSPFilterGroup_GetFilter_06(base.GetCppThis(), a_whichFilter, ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDSPFilterDefinition = (vtkDSPFilterDefinition)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDSPFilterDefinition.Register(null);
				}
			}
			return vtkDSPFilterDefinition;
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkDSPFilterGroup_GetInputVariableName_07(HandleRef pThis, int a_whichFilter);

		public string GetInputVariableName(int a_whichFilter)
		{
			return Marshal.PtrToStringAnsi(vtkDSPFilterGroup.vtkDSPFilterGroup_GetInputVariableName_07(base.GetCppThis(), a_whichFilter));
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkDSPFilterGroup_GetNumFilters_08(HandleRef pThis);

		public int GetNumFilters()
		{
			return vtkDSPFilterGroup.vtkDSPFilterGroup_GetNumFilters_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkDSPFilterGroup_GetOutput_09(HandleRef pThis, int a_whichFilter, int a_whichTimestep, ref int a_instancesCalculated, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkFloatArray GetOutput(int a_whichFilter, int a_whichTimestep, ref int a_instancesCalculated)
		{
			vtkFloatArray vtkFloatArray = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDSPFilterGroup.vtkDSPFilterGroup_GetOutput_09(base.GetCppThis(), a_whichFilter, a_whichTimestep, ref a_instancesCalculated, ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkFloatArray = (vtkFloatArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkFloatArray.Register(null);
				}
			}
			return vtkFloatArray;
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkDSPFilterGroup_IsA_10(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkDSPFilterGroup.vtkDSPFilterGroup_IsA_10(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern byte vtkDSPFilterGroup_IsThisInputVariableInstanceCached_11(HandleRef pThis, string a_name, int a_timestep);

		public bool IsThisInputVariableInstanceCached(string a_name, int a_timestep)
		{
			return vtkDSPFilterGroup.vtkDSPFilterGroup_IsThisInputVariableInstanceCached_11(base.GetCppThis(), a_name, a_timestep) != 0;
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern byte vtkDSPFilterGroup_IsThisInputVariableInstanceNeeded_12(HandleRef pThis, string a_name, int a_timestep, int a_outputTimestep);

		public bool IsThisInputVariableInstanceNeeded(string a_name, int a_timestep, int a_outputTimestep)
		{
			return vtkDSPFilterGroup.vtkDSPFilterGroup_IsThisInputVariableInstanceNeeded_12(base.GetCppThis(), a_name, a_timestep, a_outputTimestep) != 0;
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkDSPFilterGroup_IsTypeOf_13(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkDSPFilterGroup.vtkDSPFilterGroup_IsTypeOf_13(type);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkDSPFilterGroup_NewInstance_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkDSPFilterGroup NewInstance()
		{
			vtkDSPFilterGroup result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDSPFilterGroup.vtkDSPFilterGroup_NewInstance_15(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDSPFilterGroup)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkDSPFilterGroup_RemoveFilter_16(HandleRef pThis, string a_outputVariableName);

		public void RemoveFilter(string a_outputVariableName)
		{
			vtkDSPFilterGroup.vtkDSPFilterGroup_RemoveFilter_16(base.GetCppThis(), a_outputVariableName);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkDSPFilterGroup_SafeDownCast_17(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkDSPFilterGroup SafeDownCast(vtkObjectBase o)
		{
			vtkDSPFilterGroup vtkDSPFilterGroup = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDSPFilterGroup.vtkDSPFilterGroup_SafeDownCast_17((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDSPFilterGroup = (vtkDSPFilterGroup)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDSPFilterGroup.Register(null);
				}
			}
			return vtkDSPFilterGroup;
		}
	}
}
