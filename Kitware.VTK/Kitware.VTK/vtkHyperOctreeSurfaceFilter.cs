using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkHyperOctreeSurfaceFilter : vtkPolyDataAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkHyperOctreeSurfaceFilter";

		public new static readonly string MRClassNameKey;

		static vtkHyperOctreeSurfaceFilter()
		{
			vtkHyperOctreeSurfaceFilter.MRClassNameKey = "class vtkHyperOctreeSurfaceFilter";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkHyperOctreeSurfaceFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkHyperOctreeSurfaceFilter"));
		}

		public vtkHyperOctreeSurfaceFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkHyperOctreeSurfaceFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkHyperOctreeSurfaceFilter New()
		{
			vtkHyperOctreeSurfaceFilter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkHyperOctreeSurfaceFilter.vtkHyperOctreeSurfaceFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkHyperOctreeSurfaceFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkHyperOctreeSurfaceFilter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkHyperOctreeSurfaceFilter.vtkHyperOctreeSurfaceFilter_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkHyperOctreeSurfaceFilter_GetLocator_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkIncrementalPointLocator GetLocator()
		{
			vtkIncrementalPointLocator vtkIncrementalPointLocator = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkHyperOctreeSurfaceFilter.vtkHyperOctreeSurfaceFilter_GetLocator_01(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern uint vtkHyperOctreeSurfaceFilter_GetMTime_02(HandleRef pThis);

		public override uint GetMTime()
		{
			return vtkHyperOctreeSurfaceFilter.vtkHyperOctreeSurfaceFilter_GetMTime_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkHyperOctreeSurfaceFilter_GetMerging_03(HandleRef pThis);

		public virtual int GetMerging()
		{
			return vtkHyperOctreeSurfaceFilter.vtkHyperOctreeSurfaceFilter_GetMerging_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkHyperOctreeSurfaceFilter_GetPassThroughCellIds_04(HandleRef pThis);

		public virtual int GetPassThroughCellIds()
		{
			return vtkHyperOctreeSurfaceFilter.vtkHyperOctreeSurfaceFilter_GetPassThroughCellIds_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkHyperOctreeSurfaceFilter_IsA_05(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkHyperOctreeSurfaceFilter.vtkHyperOctreeSurfaceFilter_IsA_05(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkHyperOctreeSurfaceFilter_IsTypeOf_06(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkHyperOctreeSurfaceFilter.vtkHyperOctreeSurfaceFilter_IsTypeOf_06(type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkHyperOctreeSurfaceFilter_MergingOff_07(HandleRef pThis);

		public virtual void MergingOff()
		{
			vtkHyperOctreeSurfaceFilter.vtkHyperOctreeSurfaceFilter_MergingOff_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkHyperOctreeSurfaceFilter_MergingOn_08(HandleRef pThis);

		public virtual void MergingOn()
		{
			vtkHyperOctreeSurfaceFilter.vtkHyperOctreeSurfaceFilter_MergingOn_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkHyperOctreeSurfaceFilter_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkHyperOctreeSurfaceFilter NewInstance()
		{
			vtkHyperOctreeSurfaceFilter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkHyperOctreeSurfaceFilter.vtkHyperOctreeSurfaceFilter_NewInstance_10(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkHyperOctreeSurfaceFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkHyperOctreeSurfaceFilter_PassThroughCellIdsOff_11(HandleRef pThis);

		public virtual void PassThroughCellIdsOff()
		{
			vtkHyperOctreeSurfaceFilter.vtkHyperOctreeSurfaceFilter_PassThroughCellIdsOff_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkHyperOctreeSurfaceFilter_PassThroughCellIdsOn_12(HandleRef pThis);

		public virtual void PassThroughCellIdsOn()
		{
			vtkHyperOctreeSurfaceFilter.vtkHyperOctreeSurfaceFilter_PassThroughCellIdsOn_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkHyperOctreeSurfaceFilter_SafeDownCast_13(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkHyperOctreeSurfaceFilter SafeDownCast(vtkObjectBase o)
		{
			vtkHyperOctreeSurfaceFilter vtkHyperOctreeSurfaceFilter = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkHyperOctreeSurfaceFilter.vtkHyperOctreeSurfaceFilter_SafeDownCast_13((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkHyperOctreeSurfaceFilter = (vtkHyperOctreeSurfaceFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkHyperOctreeSurfaceFilter.Register(null);
				}
			}
			return vtkHyperOctreeSurfaceFilter;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkHyperOctreeSurfaceFilter_SetLocator_14(HandleRef pThis, HandleRef locator);

		public void SetLocator(vtkIncrementalPointLocator locator)
		{
			vtkHyperOctreeSurfaceFilter.vtkHyperOctreeSurfaceFilter_SetLocator_14(base.GetCppThis(), (locator == null) ? default(HandleRef) : locator.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkHyperOctreeSurfaceFilter_SetMerging_15(HandleRef pThis, int _arg);

		public virtual void SetMerging(int _arg)
		{
			vtkHyperOctreeSurfaceFilter.vtkHyperOctreeSurfaceFilter_SetMerging_15(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkHyperOctreeSurfaceFilter_SetPassThroughCellIds_16(HandleRef pThis, int _arg);

		public virtual void SetPassThroughCellIds(int _arg)
		{
			vtkHyperOctreeSurfaceFilter.vtkHyperOctreeSurfaceFilter_SetPassThroughCellIds_16(base.GetCppThis(), _arg);
		}
	}
}
