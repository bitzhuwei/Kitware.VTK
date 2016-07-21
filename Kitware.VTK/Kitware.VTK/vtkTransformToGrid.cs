using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkTransformToGrid : vtkAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkTransformToGrid";

		public new static readonly string MRClassNameKey;

		static vtkTransformToGrid()
		{
			vtkTransformToGrid.MRClassNameKey = "class vtkTransformToGrid";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkTransformToGrid.MRClassNameKey, Type.GetType("Kitware.VTK.vtkTransformToGrid"));
		}

		public vtkTransformToGrid(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkTransformToGrid_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkTransformToGrid New()
		{
			vtkTransformToGrid result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTransformToGrid.vtkTransformToGrid_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTransformToGrid)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkTransformToGrid() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkTransformToGrid.vtkTransformToGrid_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern double vtkTransformToGrid_GetDisplacementScale_01(HandleRef pThis);

		public double GetDisplacementScale()
		{
			return vtkTransformToGrid.vtkTransformToGrid_GetDisplacementScale_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern double vtkTransformToGrid_GetDisplacementShift_02(HandleRef pThis);

		public double GetDisplacementShift()
		{
			return vtkTransformToGrid.vtkTransformToGrid_GetDisplacementShift_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkTransformToGrid_GetGridExtent_03(HandleRef pThis);

		public virtual int[] GetGridExtent()
		{
			IntPtr intPtr = vtkTransformToGrid.vtkTransformToGrid_GetGridExtent_03(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkTransformToGrid_GetGridExtent_04(HandleRef pThis, ref int _arg1, ref int _arg2, ref int _arg3, ref int _arg4, ref int _arg5, ref int _arg6);

		public virtual void GetGridExtent(ref int _arg1, ref int _arg2, ref int _arg3, ref int _arg4, ref int _arg5, ref int _arg6)
		{
			vtkTransformToGrid.vtkTransformToGrid_GetGridExtent_04(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3, ref _arg4, ref _arg5, ref _arg6);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkTransformToGrid_GetGridExtent_05(HandleRef pThis, IntPtr _arg);

		public virtual void GetGridExtent(IntPtr _arg)
		{
			vtkTransformToGrid.vtkTransformToGrid_GetGridExtent_05(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkTransformToGrid_GetGridOrigin_06(HandleRef pThis);

		public virtual double[] GetGridOrigin()
		{
			IntPtr intPtr = vtkTransformToGrid.vtkTransformToGrid_GetGridOrigin_06(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkTransformToGrid_GetGridOrigin_07(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		public virtual void GetGridOrigin(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkTransformToGrid.vtkTransformToGrid_GetGridOrigin_07(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkTransformToGrid_GetGridOrigin_08(HandleRef pThis, IntPtr _arg);

		public virtual void GetGridOrigin(IntPtr _arg)
		{
			vtkTransformToGrid.vtkTransformToGrid_GetGridOrigin_08(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkTransformToGrid_GetGridScalarType_09(HandleRef pThis);

		public virtual int GetGridScalarType()
		{
			return vtkTransformToGrid.vtkTransformToGrid_GetGridScalarType_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkTransformToGrid_GetGridSpacing_10(HandleRef pThis);

		public virtual double[] GetGridSpacing()
		{
			IntPtr intPtr = vtkTransformToGrid.vtkTransformToGrid_GetGridSpacing_10(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkTransformToGrid_GetGridSpacing_11(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		public virtual void GetGridSpacing(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkTransformToGrid.vtkTransformToGrid_GetGridSpacing_11(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkTransformToGrid_GetGridSpacing_12(HandleRef pThis, IntPtr _arg);

		public virtual void GetGridSpacing(IntPtr _arg)
		{
			vtkTransformToGrid.vtkTransformToGrid_GetGridSpacing_12(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkTransformToGrid_GetInput_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkAbstractTransform GetInput()
		{
			vtkAbstractTransform vtkAbstractTransform = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTransformToGrid.vtkTransformToGrid_GetInput_13(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAbstractTransform = (vtkAbstractTransform)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAbstractTransform.Register(null);
				}
			}
			return vtkAbstractTransform;
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkTransformToGrid_GetOutput_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkImageData GetOutput()
		{
			vtkImageData vtkImageData = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTransformToGrid.vtkTransformToGrid_GetOutput_14(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageData = (vtkImageData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageData.Register(null);
				}
			}
			return vtkImageData;
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkTransformToGrid_IsA_15(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkTransformToGrid.vtkTransformToGrid_IsA_15(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkTransformToGrid_IsTypeOf_16(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkTransformToGrid.vtkTransformToGrid_IsTypeOf_16(type);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkTransformToGrid_NewInstance_18(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkTransformToGrid NewInstance()
		{
			vtkTransformToGrid result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTransformToGrid.vtkTransformToGrid_NewInstance_18(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTransformToGrid)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkTransformToGrid_SafeDownCast_19(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkTransformToGrid SafeDownCast(vtkObjectBase o)
		{
			vtkTransformToGrid vtkTransformToGrid = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTransformToGrid.vtkTransformToGrid_SafeDownCast_19((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTransformToGrid = (vtkTransformToGrid)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTransformToGrid.Register(null);
				}
			}
			return vtkTransformToGrid;
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkTransformToGrid_SetGridExtent_20(HandleRef pThis, int _arg1, int _arg2, int _arg3, int _arg4, int _arg5, int _arg6);

		public virtual void SetGridExtent(int _arg1, int _arg2, int _arg3, int _arg4, int _arg5, int _arg6)
		{
			vtkTransformToGrid.vtkTransformToGrid_SetGridExtent_20(base.GetCppThis(), _arg1, _arg2, _arg3, _arg4, _arg5, _arg6);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkTransformToGrid_SetGridExtent_21(HandleRef pThis, IntPtr _arg);

		public virtual void SetGridExtent(IntPtr _arg)
		{
			vtkTransformToGrid.vtkTransformToGrid_SetGridExtent_21(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkTransformToGrid_SetGridOrigin_22(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		public virtual void SetGridOrigin(double _arg1, double _arg2, double _arg3)
		{
			vtkTransformToGrid.vtkTransformToGrid_SetGridOrigin_22(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkTransformToGrid_SetGridOrigin_23(HandleRef pThis, IntPtr _arg);

		public virtual void SetGridOrigin(IntPtr _arg)
		{
			vtkTransformToGrid.vtkTransformToGrid_SetGridOrigin_23(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkTransformToGrid_SetGridScalarType_24(HandleRef pThis, int _arg);

		public virtual void SetGridScalarType(int _arg)
		{
			vtkTransformToGrid.vtkTransformToGrid_SetGridScalarType_24(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkTransformToGrid_SetGridScalarTypeToChar_25(HandleRef pThis);

		public void SetGridScalarTypeToChar()
		{
			vtkTransformToGrid.vtkTransformToGrid_SetGridScalarTypeToChar_25(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkTransformToGrid_SetGridScalarTypeToFloat_26(HandleRef pThis);

		public void SetGridScalarTypeToFloat()
		{
			vtkTransformToGrid.vtkTransformToGrid_SetGridScalarTypeToFloat_26(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkTransformToGrid_SetGridScalarTypeToShort_27(HandleRef pThis);

		public void SetGridScalarTypeToShort()
		{
			vtkTransformToGrid.vtkTransformToGrid_SetGridScalarTypeToShort_27(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkTransformToGrid_SetGridScalarTypeToUnsignedChar_28(HandleRef pThis);

		public void SetGridScalarTypeToUnsignedChar()
		{
			vtkTransformToGrid.vtkTransformToGrid_SetGridScalarTypeToUnsignedChar_28(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkTransformToGrid_SetGridScalarTypeToUnsignedShort_29(HandleRef pThis);

		public void SetGridScalarTypeToUnsignedShort()
		{
			vtkTransformToGrid.vtkTransformToGrid_SetGridScalarTypeToUnsignedShort_29(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkTransformToGrid_SetGridSpacing_30(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		public virtual void SetGridSpacing(double _arg1, double _arg2, double _arg3)
		{
			vtkTransformToGrid.vtkTransformToGrid_SetGridSpacing_30(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkTransformToGrid_SetGridSpacing_31(HandleRef pThis, IntPtr _arg);

		public virtual void SetGridSpacing(IntPtr _arg)
		{
			vtkTransformToGrid.vtkTransformToGrid_SetGridSpacing_31(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkTransformToGrid_SetInput_32(HandleRef pThis, HandleRef arg0);

		public virtual void SetInput(vtkAbstractTransform arg0)
		{
			vtkTransformToGrid.vtkTransformToGrid_SetInput_32(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}
	}
}
