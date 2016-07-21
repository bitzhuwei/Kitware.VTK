using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkReebGraphSurfaceSkeletonFilter : vtkDataObjectAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkReebGraphSurfaceSkeletonFilter";

		public new static readonly string MRClassNameKey;

		static vtkReebGraphSurfaceSkeletonFilter()
		{
			vtkReebGraphSurfaceSkeletonFilter.MRClassNameKey = "class vtkReebGraphSurfaceSkeletonFilter";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkReebGraphSurfaceSkeletonFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkReebGraphSurfaceSkeletonFilter"));
		}

		public vtkReebGraphSurfaceSkeletonFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkReebGraphSurfaceSkeletonFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkReebGraphSurfaceSkeletonFilter New()
		{
			vtkReebGraphSurfaceSkeletonFilter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkReebGraphSurfaceSkeletonFilter.vtkReebGraphSurfaceSkeletonFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkReebGraphSurfaceSkeletonFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkReebGraphSurfaceSkeletonFilter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkReebGraphSurfaceSkeletonFilter.vtkReebGraphSurfaceSkeletonFilter_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern long vtkReebGraphSurfaceSkeletonFilter_GetFieldId_01(HandleRef pThis);

		public virtual long GetFieldId()
		{
			return vtkReebGraphSurfaceSkeletonFilter.vtkReebGraphSurfaceSkeletonFilter_GetFieldId_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkReebGraphSurfaceSkeletonFilter_GetNumberOfSamples_02(HandleRef pThis);

		public virtual int GetNumberOfSamples()
		{
			return vtkReebGraphSurfaceSkeletonFilter.vtkReebGraphSurfaceSkeletonFilter_GetNumberOfSamples_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkReebGraphSurfaceSkeletonFilter_GetNumberOfSmoothingIterations_03(HandleRef pThis);

		public virtual int GetNumberOfSmoothingIterations()
		{
			return vtkReebGraphSurfaceSkeletonFilter.vtkReebGraphSurfaceSkeletonFilter_GetNumberOfSmoothingIterations_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkReebGraphSurfaceSkeletonFilter_GetOutput_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkTable GetOutput()
		{
			vtkTable vtkTable = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkReebGraphSurfaceSkeletonFilter.vtkReebGraphSurfaceSkeletonFilter_GetOutput_04(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTable = (vtkTable)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTable.Register(null);
				}
			}
			return vtkTable;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkReebGraphSurfaceSkeletonFilter_IsA_05(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkReebGraphSurfaceSkeletonFilter.vtkReebGraphSurfaceSkeletonFilter_IsA_05(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkReebGraphSurfaceSkeletonFilter_IsTypeOf_06(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkReebGraphSurfaceSkeletonFilter.vtkReebGraphSurfaceSkeletonFilter_IsTypeOf_06(type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkReebGraphSurfaceSkeletonFilter_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkReebGraphSurfaceSkeletonFilter NewInstance()
		{
			vtkReebGraphSurfaceSkeletonFilter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkReebGraphSurfaceSkeletonFilter.vtkReebGraphSurfaceSkeletonFilter_NewInstance_08(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkReebGraphSurfaceSkeletonFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkReebGraphSurfaceSkeletonFilter_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkReebGraphSurfaceSkeletonFilter SafeDownCast(vtkObjectBase o)
		{
			vtkReebGraphSurfaceSkeletonFilter vtkReebGraphSurfaceSkeletonFilter = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkReebGraphSurfaceSkeletonFilter.vtkReebGraphSurfaceSkeletonFilter_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkReebGraphSurfaceSkeletonFilter = (vtkReebGraphSurfaceSkeletonFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkReebGraphSurfaceSkeletonFilter.Register(null);
				}
			}
			return vtkReebGraphSurfaceSkeletonFilter;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkReebGraphSurfaceSkeletonFilter_SetFieldId_10(HandleRef pThis, long _arg);

		public virtual void SetFieldId(long _arg)
		{
			vtkReebGraphSurfaceSkeletonFilter.vtkReebGraphSurfaceSkeletonFilter_SetFieldId_10(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkReebGraphSurfaceSkeletonFilter_SetNumberOfSamples_11(HandleRef pThis, int _arg);

		public virtual void SetNumberOfSamples(int _arg)
		{
			vtkReebGraphSurfaceSkeletonFilter.vtkReebGraphSurfaceSkeletonFilter_SetNumberOfSamples_11(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkReebGraphSurfaceSkeletonFilter_SetNumberOfSmoothingIterations_12(HandleRef pThis, int _arg);

		public virtual void SetNumberOfSmoothingIterations(int _arg)
		{
			vtkReebGraphSurfaceSkeletonFilter.vtkReebGraphSurfaceSkeletonFilter_SetNumberOfSmoothingIterations_12(base.GetCppThis(), _arg);
		}
	}
}
