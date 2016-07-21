using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkImageDataGeometryFilter : vtkPolyDataAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkImageDataGeometryFilter";

		public new static readonly string MRClassNameKey;

		static vtkImageDataGeometryFilter()
		{
			vtkImageDataGeometryFilter.MRClassNameKey = "class vtkImageDataGeometryFilter";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImageDataGeometryFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageDataGeometryFilter"));
		}

		public vtkImageDataGeometryFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkImageDataGeometryFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkImageDataGeometryFilter New()
		{
			vtkImageDataGeometryFilter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageDataGeometryFilter.vtkImageDataGeometryFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageDataGeometryFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkImageDataGeometryFilter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkImageDataGeometryFilter.vtkImageDataGeometryFilter_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkImageDataGeometryFilter_GetExtent_01(HandleRef pThis);

		public IntPtr GetExtent()
		{
			return vtkImageDataGeometryFilter.vtkImageDataGeometryFilter_GetExtent_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkImageDataGeometryFilter_GetOutputTriangles_02(HandleRef pThis);

		public virtual int GetOutputTriangles()
		{
			return vtkImageDataGeometryFilter.vtkImageDataGeometryFilter_GetOutputTriangles_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkImageDataGeometryFilter_GetThresholdCells_03(HandleRef pThis);

		public virtual int GetThresholdCells()
		{
			return vtkImageDataGeometryFilter.vtkImageDataGeometryFilter_GetThresholdCells_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkImageDataGeometryFilter_GetThresholdValue_04(HandleRef pThis);

		public virtual double GetThresholdValue()
		{
			return vtkImageDataGeometryFilter.vtkImageDataGeometryFilter_GetThresholdValue_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkImageDataGeometryFilter_IsA_05(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkImageDataGeometryFilter.vtkImageDataGeometryFilter_IsA_05(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkImageDataGeometryFilter_IsTypeOf_06(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkImageDataGeometryFilter.vtkImageDataGeometryFilter_IsTypeOf_06(type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkImageDataGeometryFilter_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkImageDataGeometryFilter NewInstance()
		{
			vtkImageDataGeometryFilter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageDataGeometryFilter.vtkImageDataGeometryFilter_NewInstance_08(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageDataGeometryFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkImageDataGeometryFilter_OutputTrianglesOff_09(HandleRef pThis);

		public virtual void OutputTrianglesOff()
		{
			vtkImageDataGeometryFilter.vtkImageDataGeometryFilter_OutputTrianglesOff_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkImageDataGeometryFilter_OutputTrianglesOn_10(HandleRef pThis);

		public virtual void OutputTrianglesOn()
		{
			vtkImageDataGeometryFilter.vtkImageDataGeometryFilter_OutputTrianglesOn_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkImageDataGeometryFilter_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkImageDataGeometryFilter SafeDownCast(vtkObjectBase o)
		{
			vtkImageDataGeometryFilter vtkImageDataGeometryFilter = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageDataGeometryFilter.vtkImageDataGeometryFilter_SafeDownCast_11((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageDataGeometryFilter = (vtkImageDataGeometryFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageDataGeometryFilter.Register(null);
				}
			}
			return vtkImageDataGeometryFilter;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkImageDataGeometryFilter_SetExtent_12(HandleRef pThis, IntPtr extent);

		public void SetExtent(IntPtr extent)
		{
			vtkImageDataGeometryFilter.vtkImageDataGeometryFilter_SetExtent_12(base.GetCppThis(), extent);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkImageDataGeometryFilter_SetExtent_13(HandleRef pThis, int iMin, int iMax, int jMin, int jMax, int kMin, int kMax);

		public void SetExtent(int iMin, int iMax, int jMin, int jMax, int kMin, int kMax)
		{
			vtkImageDataGeometryFilter.vtkImageDataGeometryFilter_SetExtent_13(base.GetCppThis(), iMin, iMax, jMin, jMax, kMin, kMax);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkImageDataGeometryFilter_SetOutputTriangles_14(HandleRef pThis, int _arg);

		public virtual void SetOutputTriangles(int _arg)
		{
			vtkImageDataGeometryFilter.vtkImageDataGeometryFilter_SetOutputTriangles_14(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkImageDataGeometryFilter_SetThresholdCells_15(HandleRef pThis, int _arg);

		public virtual void SetThresholdCells(int _arg)
		{
			vtkImageDataGeometryFilter.vtkImageDataGeometryFilter_SetThresholdCells_15(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkImageDataGeometryFilter_SetThresholdValue_16(HandleRef pThis, double _arg);

		public virtual void SetThresholdValue(double _arg)
		{
			vtkImageDataGeometryFilter.vtkImageDataGeometryFilter_SetThresholdValue_16(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkImageDataGeometryFilter_ThresholdCellsOff_17(HandleRef pThis);

		public virtual void ThresholdCellsOff()
		{
			vtkImageDataGeometryFilter.vtkImageDataGeometryFilter_ThresholdCellsOff_17(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkImageDataGeometryFilter_ThresholdCellsOn_18(HandleRef pThis);

		public virtual void ThresholdCellsOn()
		{
			vtkImageDataGeometryFilter.vtkImageDataGeometryFilter_ThresholdCellsOn_18(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkImageDataGeometryFilter_ThresholdValueOff_19(HandleRef pThis);

		public virtual void ThresholdValueOff()
		{
			vtkImageDataGeometryFilter.vtkImageDataGeometryFilter_ThresholdValueOff_19(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkImageDataGeometryFilter_ThresholdValueOn_20(HandleRef pThis);

		public virtual void ThresholdValueOn()
		{
			vtkImageDataGeometryFilter.vtkImageDataGeometryFilter_ThresholdValueOn_20(base.GetCppThis());
		}
	}
}
