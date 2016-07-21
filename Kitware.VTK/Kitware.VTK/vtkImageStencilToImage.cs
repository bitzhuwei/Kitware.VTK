using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkImageStencilToImage : vtkImageAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkImageStencilToImage";

		public new static readonly string MRClassNameKey;

		static vtkImageStencilToImage()
		{
			vtkImageStencilToImage.MRClassNameKey = "class vtkImageStencilToImage";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImageStencilToImage.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageStencilToImage"));
		}

		public vtkImageStencilToImage(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageStencilToImage_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkImageStencilToImage New()
		{
			vtkImageStencilToImage result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageStencilToImage.vtkImageStencilToImage_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageStencilToImage)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkImageStencilToImage() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkImageStencilToImage.vtkImageStencilToImage_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern double vtkImageStencilToImage_GetInsideValue_01(HandleRef pThis);

		public virtual double GetInsideValue()
		{
			return vtkImageStencilToImage.vtkImageStencilToImage_GetInsideValue_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageStencilToImage_GetOutputScalarType_02(HandleRef pThis);

		public virtual int GetOutputScalarType()
		{
			return vtkImageStencilToImage.vtkImageStencilToImage_GetOutputScalarType_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern double vtkImageStencilToImage_GetOutsideValue_03(HandleRef pThis);

		public virtual double GetOutsideValue()
		{
			return vtkImageStencilToImage.vtkImageStencilToImage_GetOutsideValue_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageStencilToImage_IsA_04(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkImageStencilToImage.vtkImageStencilToImage_IsA_04(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageStencilToImage_IsTypeOf_05(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkImageStencilToImage.vtkImageStencilToImage_IsTypeOf_05(type);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageStencilToImage_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkImageStencilToImage NewInstance()
		{
			vtkImageStencilToImage result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageStencilToImage.vtkImageStencilToImage_NewInstance_07(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageStencilToImage)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageStencilToImage_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkImageStencilToImage SafeDownCast(vtkObjectBase o)
		{
			vtkImageStencilToImage vtkImageStencilToImage = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageStencilToImage.vtkImageStencilToImage_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageStencilToImage = (vtkImageStencilToImage)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageStencilToImage.Register(null);
				}
			}
			return vtkImageStencilToImage;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageStencilToImage_SetInsideValue_09(HandleRef pThis, double _arg);

		public virtual void SetInsideValue(double _arg)
		{
			vtkImageStencilToImage.vtkImageStencilToImage_SetInsideValue_09(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageStencilToImage_SetOutputScalarType_10(HandleRef pThis, int _arg);

		public virtual void SetOutputScalarType(int _arg)
		{
			vtkImageStencilToImage.vtkImageStencilToImage_SetOutputScalarType_10(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageStencilToImage_SetOutputScalarTypeToChar_11(HandleRef pThis);

		public void SetOutputScalarTypeToChar()
		{
			vtkImageStencilToImage.vtkImageStencilToImage_SetOutputScalarTypeToChar_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageStencilToImage_SetOutputScalarTypeToDouble_12(HandleRef pThis);

		public void SetOutputScalarTypeToDouble()
		{
			vtkImageStencilToImage.vtkImageStencilToImage_SetOutputScalarTypeToDouble_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageStencilToImage_SetOutputScalarTypeToFloat_13(HandleRef pThis);

		public void SetOutputScalarTypeToFloat()
		{
			vtkImageStencilToImage.vtkImageStencilToImage_SetOutputScalarTypeToFloat_13(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageStencilToImage_SetOutputScalarTypeToInt_14(HandleRef pThis);

		public void SetOutputScalarTypeToInt()
		{
			vtkImageStencilToImage.vtkImageStencilToImage_SetOutputScalarTypeToInt_14(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageStencilToImage_SetOutputScalarTypeToLong_15(HandleRef pThis);

		public void SetOutputScalarTypeToLong()
		{
			vtkImageStencilToImage.vtkImageStencilToImage_SetOutputScalarTypeToLong_15(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageStencilToImage_SetOutputScalarTypeToShort_16(HandleRef pThis);

		public void SetOutputScalarTypeToShort()
		{
			vtkImageStencilToImage.vtkImageStencilToImage_SetOutputScalarTypeToShort_16(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageStencilToImage_SetOutputScalarTypeToUnsignedChar_17(HandleRef pThis);

		public void SetOutputScalarTypeToUnsignedChar()
		{
			vtkImageStencilToImage.vtkImageStencilToImage_SetOutputScalarTypeToUnsignedChar_17(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageStencilToImage_SetOutputScalarTypeToUnsignedInt_18(HandleRef pThis);

		public void SetOutputScalarTypeToUnsignedInt()
		{
			vtkImageStencilToImage.vtkImageStencilToImage_SetOutputScalarTypeToUnsignedInt_18(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageStencilToImage_SetOutputScalarTypeToUnsignedLong_19(HandleRef pThis);

		public void SetOutputScalarTypeToUnsignedLong()
		{
			vtkImageStencilToImage.vtkImageStencilToImage_SetOutputScalarTypeToUnsignedLong_19(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageStencilToImage_SetOutputScalarTypeToUnsignedShort_20(HandleRef pThis);

		public void SetOutputScalarTypeToUnsignedShort()
		{
			vtkImageStencilToImage.vtkImageStencilToImage_SetOutputScalarTypeToUnsignedShort_20(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageStencilToImage_SetOutsideValue_21(HandleRef pThis, double _arg);

		public virtual void SetOutsideValue(double _arg)
		{
			vtkImageStencilToImage.vtkImageStencilToImage_SetOutsideValue_21(base.GetCppThis(), _arg);
		}
	}
}
