using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkContourFilter : vtkPolyDataAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkContourFilter";

		public new static readonly string MRClassNameKey;

		static vtkContourFilter()
		{
			vtkContourFilter.MRClassNameKey = "class vtkContourFilter";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkContourFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkContourFilter"));
		}

		public vtkContourFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkContourFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkContourFilter New()
		{
			vtkContourFilter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkContourFilter.vtkContourFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkContourFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkContourFilter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkContourFilter.vtkContourFilter_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkContourFilter_ComputeGradientsOff_01(HandleRef pThis);

		public virtual void ComputeGradientsOff()
		{
			vtkContourFilter.vtkContourFilter_ComputeGradientsOff_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkContourFilter_ComputeGradientsOn_02(HandleRef pThis);

		public virtual void ComputeGradientsOn()
		{
			vtkContourFilter.vtkContourFilter_ComputeGradientsOn_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkContourFilter_ComputeNormalsOff_03(HandleRef pThis);

		public virtual void ComputeNormalsOff()
		{
			vtkContourFilter.vtkContourFilter_ComputeNormalsOff_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkContourFilter_ComputeNormalsOn_04(HandleRef pThis);

		public virtual void ComputeNormalsOn()
		{
			vtkContourFilter.vtkContourFilter_ComputeNormalsOn_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkContourFilter_ComputeScalarsOff_05(HandleRef pThis);

		public virtual void ComputeScalarsOff()
		{
			vtkContourFilter.vtkContourFilter_ComputeScalarsOff_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkContourFilter_ComputeScalarsOn_06(HandleRef pThis);

		public virtual void ComputeScalarsOn()
		{
			vtkContourFilter.vtkContourFilter_ComputeScalarsOn_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkContourFilter_CreateDefaultLocator_07(HandleRef pThis);

		public void CreateDefaultLocator()
		{
			vtkContourFilter.vtkContourFilter_CreateDefaultLocator_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkContourFilter_GenerateValues_08(HandleRef pThis, int numContours, IntPtr range);

		public void GenerateValues(int numContours, IntPtr range)
		{
			vtkContourFilter.vtkContourFilter_GenerateValues_08(base.GetCppThis(), numContours, range);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkContourFilter_GenerateValues_09(HandleRef pThis, int numContours, double rangeStart, double rangeEnd);

		public void GenerateValues(int numContours, double rangeStart, double rangeEnd)
		{
			vtkContourFilter.vtkContourFilter_GenerateValues_09(base.GetCppThis(), numContours, rangeStart, rangeEnd);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkContourFilter_GetArrayComponent_10(HandleRef pThis);

		public int GetArrayComponent()
		{
			return vtkContourFilter.vtkContourFilter_GetArrayComponent_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkContourFilter_GetComputeGradients_11(HandleRef pThis);

		public virtual int GetComputeGradients()
		{
			return vtkContourFilter.vtkContourFilter_GetComputeGradients_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkContourFilter_GetComputeNormals_12(HandleRef pThis);

		public virtual int GetComputeNormals()
		{
			return vtkContourFilter.vtkContourFilter_GetComputeNormals_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkContourFilter_GetComputeScalars_13(HandleRef pThis);

		public virtual int GetComputeScalars()
		{
			return vtkContourFilter.vtkContourFilter_GetComputeScalars_13(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkContourFilter_GetLocator_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkIncrementalPointLocator GetLocator()
		{
			vtkIncrementalPointLocator vtkIncrementalPointLocator = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkContourFilter.vtkContourFilter_GetLocator_14(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern uint vtkContourFilter_GetMTime_15(HandleRef pThis);

		public override uint GetMTime()
		{
			return vtkContourFilter.vtkContourFilter_GetMTime_15(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkContourFilter_GetNumberOfContours_16(HandleRef pThis);

		public int GetNumberOfContours()
		{
			return vtkContourFilter.vtkContourFilter_GetNumberOfContours_16(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkContourFilter_GetScalarTree_17(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkScalarTree GetScalarTree()
		{
			vtkScalarTree vtkScalarTree = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkContourFilter.vtkContourFilter_GetScalarTree_17(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkScalarTree = (vtkScalarTree)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkScalarTree.Register(null);
				}
			}
			return vtkScalarTree;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkContourFilter_GetUseScalarTree_18(HandleRef pThis);

		public virtual int GetUseScalarTree()
		{
			return vtkContourFilter.vtkContourFilter_GetUseScalarTree_18(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkContourFilter_GetValue_19(HandleRef pThis, int i);

		public double GetValue(int i)
		{
			return vtkContourFilter.vtkContourFilter_GetValue_19(base.GetCppThis(), i);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkContourFilter_GetValues_20(HandleRef pThis);

		public IntPtr GetValues()
		{
			return vtkContourFilter.vtkContourFilter_GetValues_20(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkContourFilter_GetValues_21(HandleRef pThis, IntPtr contourValues);

		public void GetValues(IntPtr contourValues)
		{
			vtkContourFilter.vtkContourFilter_GetValues_21(base.GetCppThis(), contourValues);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkContourFilter_IsA_22(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkContourFilter.vtkContourFilter_IsA_22(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkContourFilter_IsTypeOf_23(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkContourFilter.vtkContourFilter_IsTypeOf_23(type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkContourFilter_NewInstance_25(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkContourFilter NewInstance()
		{
			vtkContourFilter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkContourFilter.vtkContourFilter_NewInstance_25(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkContourFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkContourFilter_SafeDownCast_26(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkContourFilter SafeDownCast(vtkObjectBase o)
		{
			vtkContourFilter vtkContourFilter = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkContourFilter.vtkContourFilter_SafeDownCast_26((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkContourFilter = (vtkContourFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkContourFilter.Register(null);
				}
			}
			return vtkContourFilter;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkContourFilter_SetArrayComponent_27(HandleRef pThis, int arg0);

		public void SetArrayComponent(int arg0)
		{
			vtkContourFilter.vtkContourFilter_SetArrayComponent_27(base.GetCppThis(), arg0);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkContourFilter_SetComputeGradients_28(HandleRef pThis, int _arg);

		public virtual void SetComputeGradients(int _arg)
		{
			vtkContourFilter.vtkContourFilter_SetComputeGradients_28(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkContourFilter_SetComputeNormals_29(HandleRef pThis, int _arg);

		public virtual void SetComputeNormals(int _arg)
		{
			vtkContourFilter.vtkContourFilter_SetComputeNormals_29(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkContourFilter_SetComputeScalars_30(HandleRef pThis, int _arg);

		public virtual void SetComputeScalars(int _arg)
		{
			vtkContourFilter.vtkContourFilter_SetComputeScalars_30(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkContourFilter_SetLocator_31(HandleRef pThis, HandleRef locator);

		public void SetLocator(vtkIncrementalPointLocator locator)
		{
			vtkContourFilter.vtkContourFilter_SetLocator_31(base.GetCppThis(), (locator == null) ? default(HandleRef) : locator.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkContourFilter_SetNumberOfContours_32(HandleRef pThis, int number);

		public void SetNumberOfContours(int number)
		{
			vtkContourFilter.vtkContourFilter_SetNumberOfContours_32(base.GetCppThis(), number);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkContourFilter_SetScalarTree_33(HandleRef pThis, HandleRef arg0);

		public virtual void SetScalarTree(vtkScalarTree arg0)
		{
			vtkContourFilter.vtkContourFilter_SetScalarTree_33(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkContourFilter_SetUseScalarTree_34(HandleRef pThis, int _arg);

		public virtual void SetUseScalarTree(int _arg)
		{
			vtkContourFilter.vtkContourFilter_SetUseScalarTree_34(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkContourFilter_SetValue_35(HandleRef pThis, int i, double value);

		public void SetValue(int i, double value)
		{
			vtkContourFilter.vtkContourFilter_SetValue_35(base.GetCppThis(), i, value);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkContourFilter_UseScalarTreeOff_36(HandleRef pThis);

		public virtual void UseScalarTreeOff()
		{
			vtkContourFilter.vtkContourFilter_UseScalarTreeOff_36(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkContourFilter_UseScalarTreeOn_37(HandleRef pThis);

		public virtual void UseScalarTreeOn()
		{
			vtkContourFilter.vtkContourFilter_UseScalarTreeOn_37(base.GetCppThis());
		}
	}
}
