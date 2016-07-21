using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkVoxelModeller : vtkImageAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkVoxelModeller";

		public new static readonly string MRClassNameKey;

		static vtkVoxelModeller()
		{
			vtkVoxelModeller.MRClassNameKey = "class vtkVoxelModeller";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkVoxelModeller.MRClassNameKey, Type.GetType("Kitware.VTK.vtkVoxelModeller"));
		}

		public vtkVoxelModeller(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkVoxelModeller_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkVoxelModeller New()
		{
			vtkVoxelModeller result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkVoxelModeller.vtkVoxelModeller_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkVoxelModeller)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkVoxelModeller() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkVoxelModeller.vtkVoxelModeller_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern double vtkVoxelModeller_ComputeModelBounds_01(HandleRef pThis, IntPtr origin, IntPtr ar);

		public double ComputeModelBounds(IntPtr origin, IntPtr ar)
		{
			return vtkVoxelModeller.vtkVoxelModeller_ComputeModelBounds_01(base.GetCppThis(), origin, ar);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern double vtkVoxelModeller_GetBackgroundValue_02(HandleRef pThis);

		public virtual double GetBackgroundValue()
		{
			return vtkVoxelModeller.vtkVoxelModeller_GetBackgroundValue_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern double vtkVoxelModeller_GetForegroundValue_03(HandleRef pThis);

		public virtual double GetForegroundValue()
		{
			return vtkVoxelModeller.vtkVoxelModeller_GetForegroundValue_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern double vtkVoxelModeller_GetMaximumDistance_04(HandleRef pThis);

		public virtual double GetMaximumDistance()
		{
			return vtkVoxelModeller.vtkVoxelModeller_GetMaximumDistance_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern double vtkVoxelModeller_GetMaximumDistanceMaxValue_05(HandleRef pThis);

		public virtual double GetMaximumDistanceMaxValue()
		{
			return vtkVoxelModeller.vtkVoxelModeller_GetMaximumDistanceMaxValue_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern double vtkVoxelModeller_GetMaximumDistanceMinValue_06(HandleRef pThis);

		public virtual double GetMaximumDistanceMinValue()
		{
			return vtkVoxelModeller.vtkVoxelModeller_GetMaximumDistanceMinValue_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkVoxelModeller_GetModelBounds_07(HandleRef pThis);

		public virtual double[] GetModelBounds()
		{
			IntPtr intPtr = vtkVoxelModeller.vtkVoxelModeller_GetModelBounds_07(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkVoxelModeller_GetModelBounds_08(HandleRef pThis, IntPtr data);

		public virtual void GetModelBounds(IntPtr data)
		{
			vtkVoxelModeller.vtkVoxelModeller_GetModelBounds_08(base.GetCppThis(), data);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkVoxelModeller_GetSampleDimensions_09(HandleRef pThis);

		public virtual int[] GetSampleDimensions()
		{
			IntPtr intPtr = vtkVoxelModeller.vtkVoxelModeller_GetSampleDimensions_09(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkVoxelModeller_GetSampleDimensions_10(HandleRef pThis, IntPtr data);

		public virtual void GetSampleDimensions(IntPtr data)
		{
			vtkVoxelModeller.vtkVoxelModeller_GetSampleDimensions_10(base.GetCppThis(), data);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkVoxelModeller_GetScalarType_11(HandleRef pThis);

		public virtual int GetScalarType()
		{
			return vtkVoxelModeller.vtkVoxelModeller_GetScalarType_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkVoxelModeller_IsA_12(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkVoxelModeller.vtkVoxelModeller_IsA_12(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkVoxelModeller_IsTypeOf_13(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkVoxelModeller.vtkVoxelModeller_IsTypeOf_13(type);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkVoxelModeller_NewInstance_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkVoxelModeller NewInstance()
		{
			vtkVoxelModeller result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkVoxelModeller.vtkVoxelModeller_NewInstance_15(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkVoxelModeller)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkVoxelModeller_SafeDownCast_16(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkVoxelModeller SafeDownCast(vtkObjectBase o)
		{
			vtkVoxelModeller vtkVoxelModeller = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkVoxelModeller.vtkVoxelModeller_SafeDownCast_16((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkVoxelModeller = (vtkVoxelModeller)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkVoxelModeller.Register(null);
				}
			}
			return vtkVoxelModeller;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkVoxelModeller_SetBackgroundValue_17(HandleRef pThis, double _arg);

		public virtual void SetBackgroundValue(double _arg)
		{
			vtkVoxelModeller.vtkVoxelModeller_SetBackgroundValue_17(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkVoxelModeller_SetForegroundValue_18(HandleRef pThis, double _arg);

		public virtual void SetForegroundValue(double _arg)
		{
			vtkVoxelModeller.vtkVoxelModeller_SetForegroundValue_18(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkVoxelModeller_SetMaximumDistance_19(HandleRef pThis, double _arg);

		public virtual void SetMaximumDistance(double _arg)
		{
			vtkVoxelModeller.vtkVoxelModeller_SetMaximumDistance_19(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkVoxelModeller_SetModelBounds_20(HandleRef pThis, IntPtr bounds);

		public void SetModelBounds(IntPtr bounds)
		{
			vtkVoxelModeller.vtkVoxelModeller_SetModelBounds_20(base.GetCppThis(), bounds);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkVoxelModeller_SetModelBounds_21(HandleRef pThis, double xmin, double xmax, double ymin, double ymax, double zmin, double zmax);

		public void SetModelBounds(double xmin, double xmax, double ymin, double ymax, double zmin, double zmax)
		{
			vtkVoxelModeller.vtkVoxelModeller_SetModelBounds_21(base.GetCppThis(), xmin, xmax, ymin, ymax, zmin, zmax);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkVoxelModeller_SetSampleDimensions_22(HandleRef pThis, int i, int j, int k);

		public void SetSampleDimensions(int i, int j, int k)
		{
			vtkVoxelModeller.vtkVoxelModeller_SetSampleDimensions_22(base.GetCppThis(), i, j, k);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkVoxelModeller_SetSampleDimensions_23(HandleRef pThis, IntPtr dim);

		public void SetSampleDimensions(IntPtr dim)
		{
			vtkVoxelModeller.vtkVoxelModeller_SetSampleDimensions_23(base.GetCppThis(), dim);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkVoxelModeller_SetScalarType_24(HandleRef pThis, int _arg);

		public virtual void SetScalarType(int _arg)
		{
			vtkVoxelModeller.vtkVoxelModeller_SetScalarType_24(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkVoxelModeller_SetScalarTypeToBit_25(HandleRef pThis);

		public void SetScalarTypeToBit()
		{
			vtkVoxelModeller.vtkVoxelModeller_SetScalarTypeToBit_25(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkVoxelModeller_SetScalarTypeToChar_26(HandleRef pThis);

		public void SetScalarTypeToChar()
		{
			vtkVoxelModeller.vtkVoxelModeller_SetScalarTypeToChar_26(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkVoxelModeller_SetScalarTypeToDouble_27(HandleRef pThis);

		public void SetScalarTypeToDouble()
		{
			vtkVoxelModeller.vtkVoxelModeller_SetScalarTypeToDouble_27(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkVoxelModeller_SetScalarTypeToFloat_28(HandleRef pThis);

		public void SetScalarTypeToFloat()
		{
			vtkVoxelModeller.vtkVoxelModeller_SetScalarTypeToFloat_28(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkVoxelModeller_SetScalarTypeToInt_29(HandleRef pThis);

		public void SetScalarTypeToInt()
		{
			vtkVoxelModeller.vtkVoxelModeller_SetScalarTypeToInt_29(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkVoxelModeller_SetScalarTypeToLong_30(HandleRef pThis);

		public void SetScalarTypeToLong()
		{
			vtkVoxelModeller.vtkVoxelModeller_SetScalarTypeToLong_30(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkVoxelModeller_SetScalarTypeToShort_31(HandleRef pThis);

		public void SetScalarTypeToShort()
		{
			vtkVoxelModeller.vtkVoxelModeller_SetScalarTypeToShort_31(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkVoxelModeller_SetScalarTypeToUnsignedChar_32(HandleRef pThis);

		public void SetScalarTypeToUnsignedChar()
		{
			vtkVoxelModeller.vtkVoxelModeller_SetScalarTypeToUnsignedChar_32(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkVoxelModeller_SetScalarTypeToUnsignedInt_33(HandleRef pThis);

		public void SetScalarTypeToUnsignedInt()
		{
			vtkVoxelModeller.vtkVoxelModeller_SetScalarTypeToUnsignedInt_33(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkVoxelModeller_SetScalarTypeToUnsignedLong_34(HandleRef pThis);

		public void SetScalarTypeToUnsignedLong()
		{
			vtkVoxelModeller.vtkVoxelModeller_SetScalarTypeToUnsignedLong_34(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkVoxelModeller_SetScalarTypeToUnsignedShort_35(HandleRef pThis);

		public void SetScalarTypeToUnsignedShort()
		{
			vtkVoxelModeller.vtkVoxelModeller_SetScalarTypeToUnsignedShort_35(base.GetCppThis());
		}
	}
}
