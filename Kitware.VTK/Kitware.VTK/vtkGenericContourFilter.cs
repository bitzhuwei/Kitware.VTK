using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkGenericContourFilter : vtkPolyDataAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkGenericContourFilter";

		public new static readonly string MRClassNameKey;

		static vtkGenericContourFilter()
		{
			vtkGenericContourFilter.MRClassNameKey = "class vtkGenericContourFilter";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkGenericContourFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkGenericContourFilter"));
		}

		public vtkGenericContourFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkGenericContourFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkGenericContourFilter New()
		{
			vtkGenericContourFilter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGenericContourFilter.vtkGenericContourFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGenericContourFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkGenericContourFilter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkGenericContourFilter.vtkGenericContourFilter_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericContourFilter_ComputeGradientsOff_01(HandleRef pThis);

		public virtual void ComputeGradientsOff()
		{
			vtkGenericContourFilter.vtkGenericContourFilter_ComputeGradientsOff_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericContourFilter_ComputeGradientsOn_02(HandleRef pThis);

		public virtual void ComputeGradientsOn()
		{
			vtkGenericContourFilter.vtkGenericContourFilter_ComputeGradientsOn_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericContourFilter_ComputeNormalsOff_03(HandleRef pThis);

		public virtual void ComputeNormalsOff()
		{
			vtkGenericContourFilter.vtkGenericContourFilter_ComputeNormalsOff_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericContourFilter_ComputeNormalsOn_04(HandleRef pThis);

		public virtual void ComputeNormalsOn()
		{
			vtkGenericContourFilter.vtkGenericContourFilter_ComputeNormalsOn_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericContourFilter_ComputeScalarsOff_05(HandleRef pThis);

		public virtual void ComputeScalarsOff()
		{
			vtkGenericContourFilter.vtkGenericContourFilter_ComputeScalarsOff_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericContourFilter_ComputeScalarsOn_06(HandleRef pThis);

		public virtual void ComputeScalarsOn()
		{
			vtkGenericContourFilter.vtkGenericContourFilter_ComputeScalarsOn_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericContourFilter_CreateDefaultLocator_07(HandleRef pThis);

		public void CreateDefaultLocator()
		{
			vtkGenericContourFilter.vtkGenericContourFilter_CreateDefaultLocator_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericContourFilter_GenerateValues_08(HandleRef pThis, int numContours, IntPtr range);

		public void GenerateValues(int numContours, IntPtr range)
		{
			vtkGenericContourFilter.vtkGenericContourFilter_GenerateValues_08(base.GetCppThis(), numContours, range);
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericContourFilter_GenerateValues_09(HandleRef pThis, int numContours, double rangeStart, double rangeEnd);

		public void GenerateValues(int numContours, double rangeStart, double rangeEnd)
		{
			vtkGenericContourFilter.vtkGenericContourFilter_GenerateValues_09(base.GetCppThis(), numContours, rangeStart, rangeEnd);
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern int vtkGenericContourFilter_GetComputeGradients_10(HandleRef pThis);

		public virtual int GetComputeGradients()
		{
			return vtkGenericContourFilter.vtkGenericContourFilter_GetComputeGradients_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern int vtkGenericContourFilter_GetComputeNormals_11(HandleRef pThis);

		public virtual int GetComputeNormals()
		{
			return vtkGenericContourFilter.vtkGenericContourFilter_GetComputeNormals_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern int vtkGenericContourFilter_GetComputeScalars_12(HandleRef pThis);

		public virtual int GetComputeScalars()
		{
			return vtkGenericContourFilter.vtkGenericContourFilter_GetComputeScalars_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkGenericContourFilter_GetInputScalarsSelection_13(HandleRef pThis);

		public virtual string GetInputScalarsSelection()
		{
			return Marshal.PtrToStringAnsi(vtkGenericContourFilter.vtkGenericContourFilter_GetInputScalarsSelection_13(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkGenericContourFilter_GetLocator_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkIncrementalPointLocator GetLocator()
		{
			vtkIncrementalPointLocator vtkIncrementalPointLocator = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGenericContourFilter.vtkGenericContourFilter_GetLocator_14(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern uint vtkGenericContourFilter_GetMTime_15(HandleRef pThis);

		public override uint GetMTime()
		{
			return vtkGenericContourFilter.vtkGenericContourFilter_GetMTime_15(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern int vtkGenericContourFilter_GetNumberOfContours_16(HandleRef pThis);

		public int GetNumberOfContours()
		{
			return vtkGenericContourFilter.vtkGenericContourFilter_GetNumberOfContours_16(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern double vtkGenericContourFilter_GetValue_17(HandleRef pThis, int i);

		public double GetValue(int i)
		{
			return vtkGenericContourFilter.vtkGenericContourFilter_GetValue_17(base.GetCppThis(), i);
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkGenericContourFilter_GetValues_18(HandleRef pThis);

		public IntPtr GetValues()
		{
			return vtkGenericContourFilter.vtkGenericContourFilter_GetValues_18(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericContourFilter_GetValues_19(HandleRef pThis, IntPtr contourValues);

		public void GetValues(IntPtr contourValues)
		{
			vtkGenericContourFilter.vtkGenericContourFilter_GetValues_19(base.GetCppThis(), contourValues);
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern int vtkGenericContourFilter_IsA_20(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkGenericContourFilter.vtkGenericContourFilter_IsA_20(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern int vtkGenericContourFilter_IsTypeOf_21(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkGenericContourFilter.vtkGenericContourFilter_IsTypeOf_21(type);
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkGenericContourFilter_NewInstance_23(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkGenericContourFilter NewInstance()
		{
			vtkGenericContourFilter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGenericContourFilter.vtkGenericContourFilter_NewInstance_23(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGenericContourFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkGenericContourFilter_SafeDownCast_24(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkGenericContourFilter SafeDownCast(vtkObjectBase o)
		{
			vtkGenericContourFilter vtkGenericContourFilter = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGenericContourFilter.vtkGenericContourFilter_SafeDownCast_24((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGenericContourFilter = (vtkGenericContourFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGenericContourFilter.Register(null);
				}
			}
			return vtkGenericContourFilter;
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericContourFilter_SelectInputScalars_25(HandleRef pThis, string fieldName);

		public virtual void SelectInputScalars(string fieldName)
		{
			vtkGenericContourFilter.vtkGenericContourFilter_SelectInputScalars_25(base.GetCppThis(), fieldName);
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericContourFilter_SetComputeGradients_26(HandleRef pThis, int _arg);

		public virtual void SetComputeGradients(int _arg)
		{
			vtkGenericContourFilter.vtkGenericContourFilter_SetComputeGradients_26(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericContourFilter_SetComputeNormals_27(HandleRef pThis, int _arg);

		public virtual void SetComputeNormals(int _arg)
		{
			vtkGenericContourFilter.vtkGenericContourFilter_SetComputeNormals_27(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericContourFilter_SetComputeScalars_28(HandleRef pThis, int _arg);

		public virtual void SetComputeScalars(int _arg)
		{
			vtkGenericContourFilter.vtkGenericContourFilter_SetComputeScalars_28(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericContourFilter_SetLocator_29(HandleRef pThis, HandleRef locator);

		public void SetLocator(vtkIncrementalPointLocator locator)
		{
			vtkGenericContourFilter.vtkGenericContourFilter_SetLocator_29(base.GetCppThis(), (locator == null) ? default(HandleRef) : locator.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericContourFilter_SetNumberOfContours_30(HandleRef pThis, int number);

		public void SetNumberOfContours(int number)
		{
			vtkGenericContourFilter.vtkGenericContourFilter_SetNumberOfContours_30(base.GetCppThis(), number);
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericContourFilter_SetValue_31(HandleRef pThis, int i, float value);

		public void SetValue(int i, float value)
		{
			vtkGenericContourFilter.vtkGenericContourFilter_SetValue_31(base.GetCppThis(), i, value);
		}
	}
}
