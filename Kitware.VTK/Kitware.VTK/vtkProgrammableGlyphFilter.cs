using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkProgrammableGlyphFilter : vtkPolyDataAlgorithm
	{
		public delegate void ProgrammableMethodCallbackType(IntPtr arg0);

		public new const string MRFullTypeName = "Kitware.VTK.vtkProgrammableGlyphFilter";

		public new static readonly string MRClassNameKey;

		static vtkProgrammableGlyphFilter()
		{
			vtkProgrammableGlyphFilter.MRClassNameKey = "class vtkProgrammableGlyphFilter";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkProgrammableGlyphFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkProgrammableGlyphFilter"));
		}

		public vtkProgrammableGlyphFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkProgrammableGlyphFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkProgrammableGlyphFilter New()
		{
			vtkProgrammableGlyphFilter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkProgrammableGlyphFilter.vtkProgrammableGlyphFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkProgrammableGlyphFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkProgrammableGlyphFilter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkProgrammableGlyphFilter.vtkProgrammableGlyphFilter_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkProgrammableGlyphFilter_GetColorMode_01(HandleRef pThis);

		public virtual int GetColorMode()
		{
			return vtkProgrammableGlyphFilter.vtkProgrammableGlyphFilter_GetColorMode_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkProgrammableGlyphFilter_GetColorModeAsString_02(HandleRef pThis);

		public string GetColorModeAsString()
		{
			return Marshal.PtrToStringAnsi(vtkProgrammableGlyphFilter.vtkProgrammableGlyphFilter_GetColorModeAsString_02(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkProgrammableGlyphFilter_GetPoint_03(HandleRef pThis);

		public virtual double[] GetPoint()
		{
			IntPtr intPtr = vtkProgrammableGlyphFilter.vtkProgrammableGlyphFilter_GetPoint_03(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkProgrammableGlyphFilter_GetPoint_04(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		public virtual void GetPoint(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkProgrammableGlyphFilter.vtkProgrammableGlyphFilter_GetPoint_04(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkProgrammableGlyphFilter_GetPoint_05(HandleRef pThis, IntPtr _arg);

		public virtual void GetPoint(IntPtr _arg)
		{
			vtkProgrammableGlyphFilter.vtkProgrammableGlyphFilter_GetPoint_05(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkProgrammableGlyphFilter_GetPointData_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkPointData GetPointData()
		{
			vtkPointData vtkPointData = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkProgrammableGlyphFilter.vtkProgrammableGlyphFilter_GetPointData_06(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPointData = (vtkPointData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPointData.Register(null);
				}
			}
			return vtkPointData;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern long vtkProgrammableGlyphFilter_GetPointId_07(HandleRef pThis);

		public virtual long GetPointId()
		{
			return vtkProgrammableGlyphFilter.vtkProgrammableGlyphFilter_GetPointId_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkProgrammableGlyphFilter_GetSource_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkPolyData GetSource()
		{
			vtkPolyData vtkPolyData = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkProgrammableGlyphFilter.vtkProgrammableGlyphFilter_GetSource_08(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPolyData = (vtkPolyData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPolyData.Register(null);
				}
			}
			return vtkPolyData;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkProgrammableGlyphFilter_IsA_09(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkProgrammableGlyphFilter.vtkProgrammableGlyphFilter_IsA_09(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkProgrammableGlyphFilter_IsTypeOf_10(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkProgrammableGlyphFilter.vtkProgrammableGlyphFilter_IsTypeOf_10(type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkProgrammableGlyphFilter_NewInstance_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkProgrammableGlyphFilter NewInstance()
		{
			vtkProgrammableGlyphFilter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkProgrammableGlyphFilter.vtkProgrammableGlyphFilter_NewInstance_12(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkProgrammableGlyphFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkProgrammableGlyphFilter_SafeDownCast_13(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkProgrammableGlyphFilter SafeDownCast(vtkObjectBase o)
		{
			vtkProgrammableGlyphFilter vtkProgrammableGlyphFilter = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkProgrammableGlyphFilter.vtkProgrammableGlyphFilter_SafeDownCast_13((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkProgrammableGlyphFilter = (vtkProgrammableGlyphFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkProgrammableGlyphFilter.Register(null);
				}
			}
			return vtkProgrammableGlyphFilter;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkProgrammableGlyphFilter_SetColorMode_14(HandleRef pThis, int _arg);

		public virtual void SetColorMode(int _arg)
		{
			vtkProgrammableGlyphFilter.vtkProgrammableGlyphFilter_SetColorMode_14(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkProgrammableGlyphFilter_SetColorModeToColorByInput_15(HandleRef pThis);

		public void SetColorModeToColorByInput()
		{
			vtkProgrammableGlyphFilter.vtkProgrammableGlyphFilter_SetColorModeToColorByInput_15(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkProgrammableGlyphFilter_SetColorModeToColorBySource_16(HandleRef pThis);

		public void SetColorModeToColorBySource()
		{
			vtkProgrammableGlyphFilter.vtkProgrammableGlyphFilter_SetColorModeToColorBySource_16(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkProgrammableGlyphFilter_SetGlyphMethod_17(HandleRef pThis, vtkProgrammableGlyphFilter.ProgrammableMethodCallbackType f, IntPtr arg);

		public void SetGlyphMethod(vtkProgrammableGlyphFilter.ProgrammableMethodCallbackType f, IntPtr arg)
		{
			vtkProgrammableGlyphFilter.vtkProgrammableGlyphFilter_SetGlyphMethod_17(base.GetCppThis(), f, arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkProgrammableGlyphFilter_SetGlyphMethodArgDelete_18(HandleRef pThis, vtkProgrammableGlyphFilter.ProgrammableMethodCallbackType f);

		public void SetGlyphMethodArgDelete(vtkProgrammableGlyphFilter.ProgrammableMethodCallbackType f)
		{
			vtkProgrammableGlyphFilter.vtkProgrammableGlyphFilter_SetGlyphMethodArgDelete_18(base.GetCppThis(), f);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkProgrammableGlyphFilter_SetSource_19(HandleRef pThis, HandleRef source);

		public void SetSource(vtkPolyData source)
		{
			vtkProgrammableGlyphFilter.vtkProgrammableGlyphFilter_SetSource_19(base.GetCppThis(), (source == null) ? default(HandleRef) : source.GetCppThis());
		}
	}
}
