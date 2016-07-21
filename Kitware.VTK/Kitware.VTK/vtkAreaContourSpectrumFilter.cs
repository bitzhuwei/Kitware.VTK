using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkAreaContourSpectrumFilter : vtkDataObjectAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkAreaContourSpectrumFilter";

		public new static readonly string MRClassNameKey;

		static vtkAreaContourSpectrumFilter()
		{
			vtkAreaContourSpectrumFilter.MRClassNameKey = "class vtkAreaContourSpectrumFilter";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkAreaContourSpectrumFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkAreaContourSpectrumFilter"));
		}

		public vtkAreaContourSpectrumFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkAreaContourSpectrumFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkAreaContourSpectrumFilter New()
		{
			vtkAreaContourSpectrumFilter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAreaContourSpectrumFilter.vtkAreaContourSpectrumFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAreaContourSpectrumFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkAreaContourSpectrumFilter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkAreaContourSpectrumFilter.vtkAreaContourSpectrumFilter_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern long vtkAreaContourSpectrumFilter_GetArcId_01(HandleRef pThis);

		public virtual long GetArcId()
		{
			return vtkAreaContourSpectrumFilter.vtkAreaContourSpectrumFilter_GetArcId_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern long vtkAreaContourSpectrumFilter_GetFieldId_02(HandleRef pThis);

		public virtual long GetFieldId()
		{
			return vtkAreaContourSpectrumFilter.vtkAreaContourSpectrumFilter_GetFieldId_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkAreaContourSpectrumFilter_GetNumberOfSamples_03(HandleRef pThis);

		public virtual int GetNumberOfSamples()
		{
			return vtkAreaContourSpectrumFilter.vtkAreaContourSpectrumFilter_GetNumberOfSamples_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkAreaContourSpectrumFilter_GetOutput_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkTable GetOutput()
		{
			vtkTable vtkTable = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAreaContourSpectrumFilter.vtkAreaContourSpectrumFilter_GetOutput_04(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern int vtkAreaContourSpectrumFilter_IsA_05(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkAreaContourSpectrumFilter.vtkAreaContourSpectrumFilter_IsA_05(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkAreaContourSpectrumFilter_IsTypeOf_06(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkAreaContourSpectrumFilter.vtkAreaContourSpectrumFilter_IsTypeOf_06(type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkAreaContourSpectrumFilter_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkAreaContourSpectrumFilter NewInstance()
		{
			vtkAreaContourSpectrumFilter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAreaContourSpectrumFilter.vtkAreaContourSpectrumFilter_NewInstance_08(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAreaContourSpectrumFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkAreaContourSpectrumFilter_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkAreaContourSpectrumFilter SafeDownCast(vtkObjectBase o)
		{
			vtkAreaContourSpectrumFilter vtkAreaContourSpectrumFilter = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAreaContourSpectrumFilter.vtkAreaContourSpectrumFilter_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAreaContourSpectrumFilter = (vtkAreaContourSpectrumFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAreaContourSpectrumFilter.Register(null);
				}
			}
			return vtkAreaContourSpectrumFilter;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkAreaContourSpectrumFilter_SetArcId_10(HandleRef pThis, long _arg);

		public virtual void SetArcId(long _arg)
		{
			vtkAreaContourSpectrumFilter.vtkAreaContourSpectrumFilter_SetArcId_10(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkAreaContourSpectrumFilter_SetFieldId_11(HandleRef pThis, long _arg);

		public virtual void SetFieldId(long _arg)
		{
			vtkAreaContourSpectrumFilter.vtkAreaContourSpectrumFilter_SetFieldId_11(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkAreaContourSpectrumFilter_SetNumberOfSamples_12(HandleRef pThis, int _arg);

		public virtual void SetNumberOfSamples(int _arg)
		{
			vtkAreaContourSpectrumFilter.vtkAreaContourSpectrumFilter_SetNumberOfSamples_12(base.GetCppThis(), _arg);
		}
	}
}
