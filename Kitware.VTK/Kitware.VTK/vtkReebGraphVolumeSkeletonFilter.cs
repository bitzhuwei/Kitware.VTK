using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkReebGraphVolumeSkeletonFilter : vtkDataObjectAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkReebGraphVolumeSkeletonFilter";

		public new static readonly string MRClassNameKey;

		static vtkReebGraphVolumeSkeletonFilter()
		{
			vtkReebGraphVolumeSkeletonFilter.MRClassNameKey = "class vtkReebGraphVolumeSkeletonFilter";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkReebGraphVolumeSkeletonFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkReebGraphVolumeSkeletonFilter"));
		}

		public vtkReebGraphVolumeSkeletonFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkReebGraphVolumeSkeletonFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkReebGraphVolumeSkeletonFilter New()
		{
			vtkReebGraphVolumeSkeletonFilter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkReebGraphVolumeSkeletonFilter.vtkReebGraphVolumeSkeletonFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkReebGraphVolumeSkeletonFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkReebGraphVolumeSkeletonFilter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkReebGraphVolumeSkeletonFilter.vtkReebGraphVolumeSkeletonFilter_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern long vtkReebGraphVolumeSkeletonFilter_GetFieldId_01(HandleRef pThis);

		public virtual long GetFieldId()
		{
			return vtkReebGraphVolumeSkeletonFilter.vtkReebGraphVolumeSkeletonFilter_GetFieldId_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkReebGraphVolumeSkeletonFilter_GetNumberOfSamples_02(HandleRef pThis);

		public virtual int GetNumberOfSamples()
		{
			return vtkReebGraphVolumeSkeletonFilter.vtkReebGraphVolumeSkeletonFilter_GetNumberOfSamples_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkReebGraphVolumeSkeletonFilter_GetNumberOfSmoothingIterations_03(HandleRef pThis);

		public virtual int GetNumberOfSmoothingIterations()
		{
			return vtkReebGraphVolumeSkeletonFilter.vtkReebGraphVolumeSkeletonFilter_GetNumberOfSmoothingIterations_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkReebGraphVolumeSkeletonFilter_GetOutput_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkTable GetOutput()
		{
			vtkTable vtkTable = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkReebGraphVolumeSkeletonFilter.vtkReebGraphVolumeSkeletonFilter_GetOutput_04(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern int vtkReebGraphVolumeSkeletonFilter_IsA_05(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkReebGraphVolumeSkeletonFilter.vtkReebGraphVolumeSkeletonFilter_IsA_05(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkReebGraphVolumeSkeletonFilter_IsTypeOf_06(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkReebGraphVolumeSkeletonFilter.vtkReebGraphVolumeSkeletonFilter_IsTypeOf_06(type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkReebGraphVolumeSkeletonFilter_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkReebGraphVolumeSkeletonFilter NewInstance()
		{
			vtkReebGraphVolumeSkeletonFilter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkReebGraphVolumeSkeletonFilter.vtkReebGraphVolumeSkeletonFilter_NewInstance_08(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkReebGraphVolumeSkeletonFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkReebGraphVolumeSkeletonFilter_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkReebGraphVolumeSkeletonFilter SafeDownCast(vtkObjectBase o)
		{
			vtkReebGraphVolumeSkeletonFilter vtkReebGraphVolumeSkeletonFilter = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkReebGraphVolumeSkeletonFilter.vtkReebGraphVolumeSkeletonFilter_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkReebGraphVolumeSkeletonFilter = (vtkReebGraphVolumeSkeletonFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkReebGraphVolumeSkeletonFilter.Register(null);
				}
			}
			return vtkReebGraphVolumeSkeletonFilter;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkReebGraphVolumeSkeletonFilter_SetFieldId_10(HandleRef pThis, long _arg);

		public virtual void SetFieldId(long _arg)
		{
			vtkReebGraphVolumeSkeletonFilter.vtkReebGraphVolumeSkeletonFilter_SetFieldId_10(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkReebGraphVolumeSkeletonFilter_SetNumberOfSamples_11(HandleRef pThis, int _arg);

		public virtual void SetNumberOfSamples(int _arg)
		{
			vtkReebGraphVolumeSkeletonFilter.vtkReebGraphVolumeSkeletonFilter_SetNumberOfSamples_11(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkReebGraphVolumeSkeletonFilter_SetNumberOfSmoothingIterations_12(HandleRef pThis, int _arg);

		public virtual void SetNumberOfSmoothingIterations(int _arg)
		{
			vtkReebGraphVolumeSkeletonFilter.vtkReebGraphVolumeSkeletonFilter_SetNumberOfSmoothingIterations_12(base.GetCppThis(), _arg);
		}
	}
}
