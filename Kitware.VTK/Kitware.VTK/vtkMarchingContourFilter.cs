using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkMarchingContourFilter : vtkPolyDataAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkMarchingContourFilter";

		public new static readonly string MRClassNameKey;

		static vtkMarchingContourFilter()
		{
			vtkMarchingContourFilter.MRClassNameKey = "class vtkMarchingContourFilter";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkMarchingContourFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkMarchingContourFilter"));
		}

		public vtkMarchingContourFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkMarchingContourFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkMarchingContourFilter New()
		{
			vtkMarchingContourFilter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkMarchingContourFilter.vtkMarchingContourFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMarchingContourFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkMarchingContourFilter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkMarchingContourFilter.vtkMarchingContourFilter_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkMarchingContourFilter_ComputeGradientsOff_01(HandleRef pThis);

		public virtual void ComputeGradientsOff()
		{
			vtkMarchingContourFilter.vtkMarchingContourFilter_ComputeGradientsOff_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkMarchingContourFilter_ComputeGradientsOn_02(HandleRef pThis);

		public virtual void ComputeGradientsOn()
		{
			vtkMarchingContourFilter.vtkMarchingContourFilter_ComputeGradientsOn_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkMarchingContourFilter_ComputeNormalsOff_03(HandleRef pThis);

		public virtual void ComputeNormalsOff()
		{
			vtkMarchingContourFilter.vtkMarchingContourFilter_ComputeNormalsOff_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkMarchingContourFilter_ComputeNormalsOn_04(HandleRef pThis);

		public virtual void ComputeNormalsOn()
		{
			vtkMarchingContourFilter.vtkMarchingContourFilter_ComputeNormalsOn_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkMarchingContourFilter_ComputeScalarsOff_05(HandleRef pThis);

		public virtual void ComputeScalarsOff()
		{
			vtkMarchingContourFilter.vtkMarchingContourFilter_ComputeScalarsOff_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkMarchingContourFilter_ComputeScalarsOn_06(HandleRef pThis);

		public virtual void ComputeScalarsOn()
		{
			vtkMarchingContourFilter.vtkMarchingContourFilter_ComputeScalarsOn_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkMarchingContourFilter_CreateDefaultLocator_07(HandleRef pThis);

		public void CreateDefaultLocator()
		{
			vtkMarchingContourFilter.vtkMarchingContourFilter_CreateDefaultLocator_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkMarchingContourFilter_GenerateValues_08(HandleRef pThis, int numContours, IntPtr range);

		public void GenerateValues(int numContours, IntPtr range)
		{
			vtkMarchingContourFilter.vtkMarchingContourFilter_GenerateValues_08(base.GetCppThis(), numContours, range);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkMarchingContourFilter_GenerateValues_09(HandleRef pThis, int numContours, double rangeStart, double rangeEnd);

		public void GenerateValues(int numContours, double rangeStart, double rangeEnd)
		{
			vtkMarchingContourFilter.vtkMarchingContourFilter_GenerateValues_09(base.GetCppThis(), numContours, rangeStart, rangeEnd);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkMarchingContourFilter_GetComputeGradients_10(HandleRef pThis);

		public virtual int GetComputeGradients()
		{
			return vtkMarchingContourFilter.vtkMarchingContourFilter_GetComputeGradients_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkMarchingContourFilter_GetComputeNormals_11(HandleRef pThis);

		public virtual int GetComputeNormals()
		{
			return vtkMarchingContourFilter.vtkMarchingContourFilter_GetComputeNormals_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkMarchingContourFilter_GetComputeScalars_12(HandleRef pThis);

		public virtual int GetComputeScalars()
		{
			return vtkMarchingContourFilter.vtkMarchingContourFilter_GetComputeScalars_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkMarchingContourFilter_GetLocator_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkIncrementalPointLocator GetLocator()
		{
			vtkIncrementalPointLocator vtkIncrementalPointLocator = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkMarchingContourFilter.vtkMarchingContourFilter_GetLocator_13(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern uint vtkMarchingContourFilter_GetMTime_14(HandleRef pThis);

		public override uint GetMTime()
		{
			return vtkMarchingContourFilter.vtkMarchingContourFilter_GetMTime_14(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkMarchingContourFilter_GetNumberOfContours_15(HandleRef pThis);

		public int GetNumberOfContours()
		{
			return vtkMarchingContourFilter.vtkMarchingContourFilter_GetNumberOfContours_15(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkMarchingContourFilter_GetUseScalarTree_16(HandleRef pThis);

		public virtual int GetUseScalarTree()
		{
			return vtkMarchingContourFilter.vtkMarchingContourFilter_GetUseScalarTree_16(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkMarchingContourFilter_GetValue_17(HandleRef pThis, int i);

		public double GetValue(int i)
		{
			return vtkMarchingContourFilter.vtkMarchingContourFilter_GetValue_17(base.GetCppThis(), i);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkMarchingContourFilter_GetValues_18(HandleRef pThis);

		public IntPtr GetValues()
		{
			return vtkMarchingContourFilter.vtkMarchingContourFilter_GetValues_18(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkMarchingContourFilter_GetValues_19(HandleRef pThis, IntPtr contourValues);

		public void GetValues(IntPtr contourValues)
		{
			vtkMarchingContourFilter.vtkMarchingContourFilter_GetValues_19(base.GetCppThis(), contourValues);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkMarchingContourFilter_IsA_20(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkMarchingContourFilter.vtkMarchingContourFilter_IsA_20(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkMarchingContourFilter_IsTypeOf_21(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkMarchingContourFilter.vtkMarchingContourFilter_IsTypeOf_21(type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkMarchingContourFilter_NewInstance_23(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkMarchingContourFilter NewInstance()
		{
			vtkMarchingContourFilter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkMarchingContourFilter.vtkMarchingContourFilter_NewInstance_23(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMarchingContourFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkMarchingContourFilter_SafeDownCast_24(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkMarchingContourFilter SafeDownCast(vtkObjectBase o)
		{
			vtkMarchingContourFilter vtkMarchingContourFilter = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkMarchingContourFilter.vtkMarchingContourFilter_SafeDownCast_24((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMarchingContourFilter = (vtkMarchingContourFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMarchingContourFilter.Register(null);
				}
			}
			return vtkMarchingContourFilter;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkMarchingContourFilter_SetComputeGradients_25(HandleRef pThis, int _arg);

		public virtual void SetComputeGradients(int _arg)
		{
			vtkMarchingContourFilter.vtkMarchingContourFilter_SetComputeGradients_25(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkMarchingContourFilter_SetComputeNormals_26(HandleRef pThis, int _arg);

		public virtual void SetComputeNormals(int _arg)
		{
			vtkMarchingContourFilter.vtkMarchingContourFilter_SetComputeNormals_26(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkMarchingContourFilter_SetComputeScalars_27(HandleRef pThis, int _arg);

		public virtual void SetComputeScalars(int _arg)
		{
			vtkMarchingContourFilter.vtkMarchingContourFilter_SetComputeScalars_27(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkMarchingContourFilter_SetLocator_28(HandleRef pThis, HandleRef locator);

		public void SetLocator(vtkIncrementalPointLocator locator)
		{
			vtkMarchingContourFilter.vtkMarchingContourFilter_SetLocator_28(base.GetCppThis(), (locator == null) ? default(HandleRef) : locator.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkMarchingContourFilter_SetNumberOfContours_29(HandleRef pThis, int number);

		public void SetNumberOfContours(int number)
		{
			vtkMarchingContourFilter.vtkMarchingContourFilter_SetNumberOfContours_29(base.GetCppThis(), number);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkMarchingContourFilter_SetUseScalarTree_30(HandleRef pThis, int _arg);

		public virtual void SetUseScalarTree(int _arg)
		{
			vtkMarchingContourFilter.vtkMarchingContourFilter_SetUseScalarTree_30(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkMarchingContourFilter_SetValue_31(HandleRef pThis, int i, double value);

		public void SetValue(int i, double value)
		{
			vtkMarchingContourFilter.vtkMarchingContourFilter_SetValue_31(base.GetCppThis(), i, value);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkMarchingContourFilter_UseScalarTreeOff_32(HandleRef pThis);

		public virtual void UseScalarTreeOff()
		{
			vtkMarchingContourFilter.vtkMarchingContourFilter_UseScalarTreeOff_32(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkMarchingContourFilter_UseScalarTreeOn_33(HandleRef pThis);

		public virtual void UseScalarTreeOn()
		{
			vtkMarchingContourFilter.vtkMarchingContourFilter_UseScalarTreeOn_33(base.GetCppThis());
		}
	}
}
