using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkImageEllipsoidSource : vtkImageAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkImageEllipsoidSource";

		public new static readonly string MRClassNameKey;

		static vtkImageEllipsoidSource()
		{
			vtkImageEllipsoidSource.MRClassNameKey = "class vtkImageEllipsoidSource";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImageEllipsoidSource.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageEllipsoidSource"));
		}

		public vtkImageEllipsoidSource(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageEllipsoidSource_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkImageEllipsoidSource New()
		{
			vtkImageEllipsoidSource result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageEllipsoidSource.vtkImageEllipsoidSource_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageEllipsoidSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkImageEllipsoidSource() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkImageEllipsoidSource.vtkImageEllipsoidSource_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageEllipsoidSource_GetCenter_01(HandleRef pThis);

		public virtual double[] GetCenter()
		{
			IntPtr intPtr = vtkImageEllipsoidSource.vtkImageEllipsoidSource_GetCenter_01(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageEllipsoidSource_GetCenter_02(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		public virtual void GetCenter(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkImageEllipsoidSource.vtkImageEllipsoidSource_GetCenter_02(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageEllipsoidSource_GetCenter_03(HandleRef pThis, IntPtr _arg);

		public virtual void GetCenter(IntPtr _arg)
		{
			vtkImageEllipsoidSource.vtkImageEllipsoidSource_GetCenter_03(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern double vtkImageEllipsoidSource_GetInValue_04(HandleRef pThis);

		public virtual double GetInValue()
		{
			return vtkImageEllipsoidSource.vtkImageEllipsoidSource_GetInValue_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern double vtkImageEllipsoidSource_GetOutValue_05(HandleRef pThis);

		public virtual double GetOutValue()
		{
			return vtkImageEllipsoidSource.vtkImageEllipsoidSource_GetOutValue_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageEllipsoidSource_GetOutputScalarType_06(HandleRef pThis);

		public virtual int GetOutputScalarType()
		{
			return vtkImageEllipsoidSource.vtkImageEllipsoidSource_GetOutputScalarType_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageEllipsoidSource_GetRadius_07(HandleRef pThis);

		public virtual double[] GetRadius()
		{
			IntPtr intPtr = vtkImageEllipsoidSource.vtkImageEllipsoidSource_GetRadius_07(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageEllipsoidSource_GetRadius_08(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		public virtual void GetRadius(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkImageEllipsoidSource.vtkImageEllipsoidSource_GetRadius_08(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageEllipsoidSource_GetRadius_09(HandleRef pThis, IntPtr _arg);

		public virtual void GetRadius(IntPtr _arg)
		{
			vtkImageEllipsoidSource.vtkImageEllipsoidSource_GetRadius_09(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageEllipsoidSource_GetWholeExtent_10(HandleRef pThis, IntPtr extent);

		public void GetWholeExtent(IntPtr extent)
		{
			vtkImageEllipsoidSource.vtkImageEllipsoidSource_GetWholeExtent_10(base.GetCppThis(), extent);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageEllipsoidSource_GetWholeExtent_11(HandleRef pThis);

		public int[] GetWholeExtent()
		{
			IntPtr intPtr = vtkImageEllipsoidSource.vtkImageEllipsoidSource_GetWholeExtent_11(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageEllipsoidSource_IsA_12(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkImageEllipsoidSource.vtkImageEllipsoidSource_IsA_12(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageEllipsoidSource_IsTypeOf_13(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkImageEllipsoidSource.vtkImageEllipsoidSource_IsTypeOf_13(type);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageEllipsoidSource_NewInstance_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkImageEllipsoidSource NewInstance()
		{
			vtkImageEllipsoidSource result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageEllipsoidSource.vtkImageEllipsoidSource_NewInstance_15(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageEllipsoidSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageEllipsoidSource_SafeDownCast_16(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkImageEllipsoidSource SafeDownCast(vtkObjectBase o)
		{
			vtkImageEllipsoidSource vtkImageEllipsoidSource = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageEllipsoidSource.vtkImageEllipsoidSource_SafeDownCast_16((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageEllipsoidSource = (vtkImageEllipsoidSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageEllipsoidSource.Register(null);
				}
			}
			return vtkImageEllipsoidSource;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageEllipsoidSource_SetCenter_17(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		public virtual void SetCenter(double _arg1, double _arg2, double _arg3)
		{
			vtkImageEllipsoidSource.vtkImageEllipsoidSource_SetCenter_17(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageEllipsoidSource_SetCenter_18(HandleRef pThis, IntPtr _arg);

		public virtual void SetCenter(IntPtr _arg)
		{
			vtkImageEllipsoidSource.vtkImageEllipsoidSource_SetCenter_18(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageEllipsoidSource_SetInValue_19(HandleRef pThis, double _arg);

		public virtual void SetInValue(double _arg)
		{
			vtkImageEllipsoidSource.vtkImageEllipsoidSource_SetInValue_19(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageEllipsoidSource_SetOutValue_20(HandleRef pThis, double _arg);

		public virtual void SetOutValue(double _arg)
		{
			vtkImageEllipsoidSource.vtkImageEllipsoidSource_SetOutValue_20(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageEllipsoidSource_SetOutputScalarType_21(HandleRef pThis, int _arg);

		public virtual void SetOutputScalarType(int _arg)
		{
			vtkImageEllipsoidSource.vtkImageEllipsoidSource_SetOutputScalarType_21(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageEllipsoidSource_SetOutputScalarTypeToChar_22(HandleRef pThis);

		public void SetOutputScalarTypeToChar()
		{
			vtkImageEllipsoidSource.vtkImageEllipsoidSource_SetOutputScalarTypeToChar_22(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageEllipsoidSource_SetOutputScalarTypeToDouble_23(HandleRef pThis);

		public void SetOutputScalarTypeToDouble()
		{
			vtkImageEllipsoidSource.vtkImageEllipsoidSource_SetOutputScalarTypeToDouble_23(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageEllipsoidSource_SetOutputScalarTypeToFloat_24(HandleRef pThis);

		public void SetOutputScalarTypeToFloat()
		{
			vtkImageEllipsoidSource.vtkImageEllipsoidSource_SetOutputScalarTypeToFloat_24(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageEllipsoidSource_SetOutputScalarTypeToInt_25(HandleRef pThis);

		public void SetOutputScalarTypeToInt()
		{
			vtkImageEllipsoidSource.vtkImageEllipsoidSource_SetOutputScalarTypeToInt_25(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageEllipsoidSource_SetOutputScalarTypeToLong_26(HandleRef pThis);

		public void SetOutputScalarTypeToLong()
		{
			vtkImageEllipsoidSource.vtkImageEllipsoidSource_SetOutputScalarTypeToLong_26(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageEllipsoidSource_SetOutputScalarTypeToShort_27(HandleRef pThis);

		public void SetOutputScalarTypeToShort()
		{
			vtkImageEllipsoidSource.vtkImageEllipsoidSource_SetOutputScalarTypeToShort_27(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageEllipsoidSource_SetOutputScalarTypeToUnsignedChar_28(HandleRef pThis);

		public void SetOutputScalarTypeToUnsignedChar()
		{
			vtkImageEllipsoidSource.vtkImageEllipsoidSource_SetOutputScalarTypeToUnsignedChar_28(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageEllipsoidSource_SetOutputScalarTypeToUnsignedInt_29(HandleRef pThis);

		public void SetOutputScalarTypeToUnsignedInt()
		{
			vtkImageEllipsoidSource.vtkImageEllipsoidSource_SetOutputScalarTypeToUnsignedInt_29(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageEllipsoidSource_SetOutputScalarTypeToUnsignedLong_30(HandleRef pThis);

		public void SetOutputScalarTypeToUnsignedLong()
		{
			vtkImageEllipsoidSource.vtkImageEllipsoidSource_SetOutputScalarTypeToUnsignedLong_30(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageEllipsoidSource_SetOutputScalarTypeToUnsignedShort_31(HandleRef pThis);

		public void SetOutputScalarTypeToUnsignedShort()
		{
			vtkImageEllipsoidSource.vtkImageEllipsoidSource_SetOutputScalarTypeToUnsignedShort_31(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageEllipsoidSource_SetRadius_32(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		public virtual void SetRadius(double _arg1, double _arg2, double _arg3)
		{
			vtkImageEllipsoidSource.vtkImageEllipsoidSource_SetRadius_32(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageEllipsoidSource_SetRadius_33(HandleRef pThis, IntPtr _arg);

		public virtual void SetRadius(IntPtr _arg)
		{
			vtkImageEllipsoidSource.vtkImageEllipsoidSource_SetRadius_33(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageEllipsoidSource_SetWholeExtent_34(HandleRef pThis, IntPtr extent);

		public void SetWholeExtent(IntPtr extent)
		{
			vtkImageEllipsoidSource.vtkImageEllipsoidSource_SetWholeExtent_34(base.GetCppThis(), extent);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageEllipsoidSource_SetWholeExtent_35(HandleRef pThis, int minX, int maxX, int minY, int maxY, int minZ, int maxZ);

		public void SetWholeExtent(int minX, int maxX, int minY, int maxY, int minZ, int maxZ)
		{
			vtkImageEllipsoidSource.vtkImageEllipsoidSource_SetWholeExtent_35(base.GetCppThis(), minX, maxX, minY, maxY, minZ, maxZ);
		}
	}
}
