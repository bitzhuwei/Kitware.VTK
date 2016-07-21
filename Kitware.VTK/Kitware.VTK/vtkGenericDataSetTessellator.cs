using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkGenericDataSetTessellator : vtkUnstructuredGridAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkGenericDataSetTessellator";

		public new static readonly string MRClassNameKey;

		static vtkGenericDataSetTessellator()
		{
			vtkGenericDataSetTessellator.MRClassNameKey = "class vtkGenericDataSetTessellator";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkGenericDataSetTessellator.MRClassNameKey, Type.GetType("Kitware.VTK.vtkGenericDataSetTessellator"));
		}

		public vtkGenericDataSetTessellator(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkGenericDataSetTessellator_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkGenericDataSetTessellator New()
		{
			vtkGenericDataSetTessellator result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGenericDataSetTessellator.vtkGenericDataSetTessellator_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGenericDataSetTessellator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkGenericDataSetTessellator() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkGenericDataSetTessellator.vtkGenericDataSetTessellator_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericDataSetTessellator_CreateDefaultLocator_01(HandleRef pThis);

		public void CreateDefaultLocator()
		{
			vtkGenericDataSetTessellator.vtkGenericDataSetTessellator_CreateDefaultLocator_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern int vtkGenericDataSetTessellator_GetKeepCellIds_02(HandleRef pThis);

		public virtual int GetKeepCellIds()
		{
			return vtkGenericDataSetTessellator.vtkGenericDataSetTessellator_GetKeepCellIds_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkGenericDataSetTessellator_GetLocator_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkIncrementalPointLocator GetLocator()
		{
			vtkIncrementalPointLocator vtkIncrementalPointLocator = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGenericDataSetTessellator.vtkGenericDataSetTessellator_GetLocator_03(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkIncrementalPointLocator = (vtkIncrementalPointLocator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkIncrementalPointLocator.Register(null);
				}
			}
			return vtkIncrementalPointLocator;
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern uint vtkGenericDataSetTessellator_GetMTime_04(HandleRef pThis);

		public override uint GetMTime()
		{
			return vtkGenericDataSetTessellator.vtkGenericDataSetTessellator_GetMTime_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern int vtkGenericDataSetTessellator_GetMerging_05(HandleRef pThis);

		public virtual int GetMerging()
		{
			return vtkGenericDataSetTessellator.vtkGenericDataSetTessellator_GetMerging_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern int vtkGenericDataSetTessellator_IsA_06(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkGenericDataSetTessellator.vtkGenericDataSetTessellator_IsA_06(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern int vtkGenericDataSetTessellator_IsTypeOf_07(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkGenericDataSetTessellator.vtkGenericDataSetTessellator_IsTypeOf_07(type);
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericDataSetTessellator_KeepCellIdsOff_08(HandleRef pThis);

		public virtual void KeepCellIdsOff()
		{
			vtkGenericDataSetTessellator.vtkGenericDataSetTessellator_KeepCellIdsOff_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericDataSetTessellator_KeepCellIdsOn_09(HandleRef pThis);

		public virtual void KeepCellIdsOn()
		{
			vtkGenericDataSetTessellator.vtkGenericDataSetTessellator_KeepCellIdsOn_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericDataSetTessellator_MergingOff_10(HandleRef pThis);

		public virtual void MergingOff()
		{
			vtkGenericDataSetTessellator.vtkGenericDataSetTessellator_MergingOff_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericDataSetTessellator_MergingOn_11(HandleRef pThis);

		public virtual void MergingOn()
		{
			vtkGenericDataSetTessellator.vtkGenericDataSetTessellator_MergingOn_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkGenericDataSetTessellator_NewInstance_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkGenericDataSetTessellator NewInstance()
		{
			vtkGenericDataSetTessellator result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGenericDataSetTessellator.vtkGenericDataSetTessellator_NewInstance_13(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGenericDataSetTessellator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkGenericDataSetTessellator_SafeDownCast_14(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkGenericDataSetTessellator SafeDownCast(vtkObjectBase o)
		{
			vtkGenericDataSetTessellator vtkGenericDataSetTessellator = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGenericDataSetTessellator.vtkGenericDataSetTessellator_SafeDownCast_14((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGenericDataSetTessellator = (vtkGenericDataSetTessellator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGenericDataSetTessellator.Register(null);
				}
			}
			return vtkGenericDataSetTessellator;
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericDataSetTessellator_SetKeepCellIds_15(HandleRef pThis, int _arg);

		public virtual void SetKeepCellIds(int _arg)
		{
			vtkGenericDataSetTessellator.vtkGenericDataSetTessellator_SetKeepCellIds_15(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericDataSetTessellator_SetLocator_16(HandleRef pThis, HandleRef locator);

		public void SetLocator(vtkIncrementalPointLocator locator)
		{
			vtkGenericDataSetTessellator.vtkGenericDataSetTessellator_SetLocator_16(base.GetCppThis(), (locator == null) ? default(HandleRef) : locator.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericDataSetTessellator_SetMerging_17(HandleRef pThis, int _arg);

		public virtual void SetMerging(int _arg)
		{
			vtkGenericDataSetTessellator.vtkGenericDataSetTessellator_SetMerging_17(base.GetCppThis(), _arg);
		}
	}
}
