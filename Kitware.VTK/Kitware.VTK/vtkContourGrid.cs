using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkContourGrid : vtkPolyDataAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkContourGrid";

		public new static readonly string MRClassNameKey;

		static vtkContourGrid()
		{
			vtkContourGrid.MRClassNameKey = "class vtkContourGrid";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkContourGrid.MRClassNameKey, Type.GetType("Kitware.VTK.vtkContourGrid"));
		}

		public vtkContourGrid(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkContourGrid_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkContourGrid New()
		{
			vtkContourGrid result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkContourGrid.vtkContourGrid_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkContourGrid)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkContourGrid() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkContourGrid.vtkContourGrid_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkContourGrid_ComputeGradientsOff_01(HandleRef pThis);

		public virtual void ComputeGradientsOff()
		{
			vtkContourGrid.vtkContourGrid_ComputeGradientsOff_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkContourGrid_ComputeGradientsOn_02(HandleRef pThis);

		public virtual void ComputeGradientsOn()
		{
			vtkContourGrid.vtkContourGrid_ComputeGradientsOn_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkContourGrid_ComputeNormalsOff_03(HandleRef pThis);

		public virtual void ComputeNormalsOff()
		{
			vtkContourGrid.vtkContourGrid_ComputeNormalsOff_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkContourGrid_ComputeNormalsOn_04(HandleRef pThis);

		public virtual void ComputeNormalsOn()
		{
			vtkContourGrid.vtkContourGrid_ComputeNormalsOn_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkContourGrid_ComputeScalarsOff_05(HandleRef pThis);

		public virtual void ComputeScalarsOff()
		{
			vtkContourGrid.vtkContourGrid_ComputeScalarsOff_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkContourGrid_ComputeScalarsOn_06(HandleRef pThis);

		public virtual void ComputeScalarsOn()
		{
			vtkContourGrid.vtkContourGrid_ComputeScalarsOn_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkContourGrid_CreateDefaultLocator_07(HandleRef pThis);

		public void CreateDefaultLocator()
		{
			vtkContourGrid.vtkContourGrid_CreateDefaultLocator_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkContourGrid_GenerateValues_08(HandleRef pThis, int numContours, IntPtr range);

		public void GenerateValues(int numContours, IntPtr range)
		{
			vtkContourGrid.vtkContourGrid_GenerateValues_08(base.GetCppThis(), numContours, range);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkContourGrid_GenerateValues_09(HandleRef pThis, int numContours, double rangeStart, double rangeEnd);

		public void GenerateValues(int numContours, double rangeStart, double rangeEnd)
		{
			vtkContourGrid.vtkContourGrid_GenerateValues_09(base.GetCppThis(), numContours, rangeStart, rangeEnd);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkContourGrid_GetComputeGradients_10(HandleRef pThis);

		public virtual int GetComputeGradients()
		{
			return vtkContourGrid.vtkContourGrid_GetComputeGradients_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkContourGrid_GetComputeNormals_11(HandleRef pThis);

		public virtual int GetComputeNormals()
		{
			return vtkContourGrid.vtkContourGrid_GetComputeNormals_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkContourGrid_GetComputeScalars_12(HandleRef pThis);

		public virtual int GetComputeScalars()
		{
			return vtkContourGrid.vtkContourGrid_GetComputeScalars_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkContourGrid_GetLocator_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkIncrementalPointLocator GetLocator()
		{
			vtkIncrementalPointLocator vtkIncrementalPointLocator = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkContourGrid.vtkContourGrid_GetLocator_13(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern uint vtkContourGrid_GetMTime_14(HandleRef pThis);

		public override uint GetMTime()
		{
			return vtkContourGrid.vtkContourGrid_GetMTime_14(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkContourGrid_GetNumberOfContours_15(HandleRef pThis);

		public int GetNumberOfContours()
		{
			return vtkContourGrid.vtkContourGrid_GetNumberOfContours_15(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkContourGrid_GetUseScalarTree_16(HandleRef pThis);

		public virtual int GetUseScalarTree()
		{
			return vtkContourGrid.vtkContourGrid_GetUseScalarTree_16(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkContourGrid_GetValue_17(HandleRef pThis, int i);

		public double GetValue(int i)
		{
			return vtkContourGrid.vtkContourGrid_GetValue_17(base.GetCppThis(), i);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkContourGrid_GetValues_18(HandleRef pThis);

		public IntPtr GetValues()
		{
			return vtkContourGrid.vtkContourGrid_GetValues_18(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkContourGrid_GetValues_19(HandleRef pThis, IntPtr contourValues);

		public void GetValues(IntPtr contourValues)
		{
			vtkContourGrid.vtkContourGrid_GetValues_19(base.GetCppThis(), contourValues);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkContourGrid_IsA_20(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkContourGrid.vtkContourGrid_IsA_20(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkContourGrid_IsTypeOf_21(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkContourGrid.vtkContourGrid_IsTypeOf_21(type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkContourGrid_NewInstance_23(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkContourGrid NewInstance()
		{
			vtkContourGrid result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkContourGrid.vtkContourGrid_NewInstance_23(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkContourGrid)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkContourGrid_SafeDownCast_24(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkContourGrid SafeDownCast(vtkObjectBase o)
		{
			vtkContourGrid vtkContourGrid = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkContourGrid.vtkContourGrid_SafeDownCast_24((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkContourGrid = (vtkContourGrid)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkContourGrid.Register(null);
				}
			}
			return vtkContourGrid;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkContourGrid_SetComputeGradients_25(HandleRef pThis, int _arg);

		public virtual void SetComputeGradients(int _arg)
		{
			vtkContourGrid.vtkContourGrid_SetComputeGradients_25(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkContourGrid_SetComputeNormals_26(HandleRef pThis, int _arg);

		public virtual void SetComputeNormals(int _arg)
		{
			vtkContourGrid.vtkContourGrid_SetComputeNormals_26(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkContourGrid_SetComputeScalars_27(HandleRef pThis, int _arg);

		public virtual void SetComputeScalars(int _arg)
		{
			vtkContourGrid.vtkContourGrid_SetComputeScalars_27(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkContourGrid_SetLocator_28(HandleRef pThis, HandleRef locator);

		public void SetLocator(vtkIncrementalPointLocator locator)
		{
			vtkContourGrid.vtkContourGrid_SetLocator_28(base.GetCppThis(), (locator == null) ? default(HandleRef) : locator.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkContourGrid_SetNumberOfContours_29(HandleRef pThis, int number);

		public void SetNumberOfContours(int number)
		{
			vtkContourGrid.vtkContourGrid_SetNumberOfContours_29(base.GetCppThis(), number);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkContourGrid_SetUseScalarTree_30(HandleRef pThis, int _arg);

		public virtual void SetUseScalarTree(int _arg)
		{
			vtkContourGrid.vtkContourGrid_SetUseScalarTree_30(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkContourGrid_SetValue_31(HandleRef pThis, int i, double value);

		public void SetValue(int i, double value)
		{
			vtkContourGrid.vtkContourGrid_SetValue_31(base.GetCppThis(), i, value);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkContourGrid_UseScalarTreeOff_32(HandleRef pThis);

		public virtual void UseScalarTreeOff()
		{
			vtkContourGrid.vtkContourGrid_UseScalarTreeOff_32(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkContourGrid_UseScalarTreeOn_33(HandleRef pThis);

		public virtual void UseScalarTreeOn()
		{
			vtkContourGrid.vtkContourGrid_UseScalarTreeOn_33(base.GetCppThis());
		}
	}
}
