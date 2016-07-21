using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkVolumeContourSpectrumFilter : vtkDataObjectAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkVolumeContourSpectrumFilter";

		public new static readonly string MRClassNameKey;

		static vtkVolumeContourSpectrumFilter()
		{
			vtkVolumeContourSpectrumFilter.MRClassNameKey = "class vtkVolumeContourSpectrumFilter";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkVolumeContourSpectrumFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkVolumeContourSpectrumFilter"));
		}

		public vtkVolumeContourSpectrumFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkVolumeContourSpectrumFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkVolumeContourSpectrumFilter New()
		{
			vtkVolumeContourSpectrumFilter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkVolumeContourSpectrumFilter.vtkVolumeContourSpectrumFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkVolumeContourSpectrumFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkVolumeContourSpectrumFilter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkVolumeContourSpectrumFilter.vtkVolumeContourSpectrumFilter_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern long vtkVolumeContourSpectrumFilter_GetArcId_01(HandleRef pThis);

		public virtual long GetArcId()
		{
			return vtkVolumeContourSpectrumFilter.vtkVolumeContourSpectrumFilter_GetArcId_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern long vtkVolumeContourSpectrumFilter_GetFieldId_02(HandleRef pThis);

		public virtual long GetFieldId()
		{
			return vtkVolumeContourSpectrumFilter.vtkVolumeContourSpectrumFilter_GetFieldId_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkVolumeContourSpectrumFilter_GetNumberOfSamples_03(HandleRef pThis);

		public virtual int GetNumberOfSamples()
		{
			return vtkVolumeContourSpectrumFilter.vtkVolumeContourSpectrumFilter_GetNumberOfSamples_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkVolumeContourSpectrumFilter_GetOutput_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkTable GetOutput()
		{
			vtkTable vtkTable = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkVolumeContourSpectrumFilter.vtkVolumeContourSpectrumFilter_GetOutput_04(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern int vtkVolumeContourSpectrumFilter_IsA_05(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkVolumeContourSpectrumFilter.vtkVolumeContourSpectrumFilter_IsA_05(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkVolumeContourSpectrumFilter_IsTypeOf_06(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkVolumeContourSpectrumFilter.vtkVolumeContourSpectrumFilter_IsTypeOf_06(type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkVolumeContourSpectrumFilter_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkVolumeContourSpectrumFilter NewInstance()
		{
			vtkVolumeContourSpectrumFilter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkVolumeContourSpectrumFilter.vtkVolumeContourSpectrumFilter_NewInstance_08(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkVolumeContourSpectrumFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkVolumeContourSpectrumFilter_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkVolumeContourSpectrumFilter SafeDownCast(vtkObjectBase o)
		{
			vtkVolumeContourSpectrumFilter vtkVolumeContourSpectrumFilter = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkVolumeContourSpectrumFilter.vtkVolumeContourSpectrumFilter_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkVolumeContourSpectrumFilter = (vtkVolumeContourSpectrumFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkVolumeContourSpectrumFilter.Register(null);
				}
			}
			return vtkVolumeContourSpectrumFilter;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkVolumeContourSpectrumFilter_SetArcId_10(HandleRef pThis, long _arg);

		public virtual void SetArcId(long _arg)
		{
			vtkVolumeContourSpectrumFilter.vtkVolumeContourSpectrumFilter_SetArcId_10(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkVolumeContourSpectrumFilter_SetFieldId_11(HandleRef pThis, long _arg);

		public virtual void SetFieldId(long _arg)
		{
			vtkVolumeContourSpectrumFilter.vtkVolumeContourSpectrumFilter_SetFieldId_11(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkVolumeContourSpectrumFilter_SetNumberOfSamples_12(HandleRef pThis, int _arg);

		public virtual void SetNumberOfSamples(int _arg)
		{
			vtkVolumeContourSpectrumFilter.vtkVolumeContourSpectrumFilter_SetNumberOfSamples_12(base.GetCppThis(), _arg);
		}
	}
}
