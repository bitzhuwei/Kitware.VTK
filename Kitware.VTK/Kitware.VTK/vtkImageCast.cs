using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkImageCast : vtkThreadedImageAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkImageCast";

		public new static readonly string MRClassNameKey;

		static vtkImageCast()
		{
			vtkImageCast.MRClassNameKey = "class vtkImageCast";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImageCast.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageCast"));
		}

		public vtkImageCast(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageCast_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkImageCast New()
		{
			vtkImageCast result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageCast.vtkImageCast_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageCast)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkImageCast() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkImageCast.vtkImageCast_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageCast_ClampOverflowOff_01(HandleRef pThis);

		public virtual void ClampOverflowOff()
		{
			vtkImageCast.vtkImageCast_ClampOverflowOff_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageCast_ClampOverflowOn_02(HandleRef pThis);

		public virtual void ClampOverflowOn()
		{
			vtkImageCast.vtkImageCast_ClampOverflowOn_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageCast_GetClampOverflow_03(HandleRef pThis);

		public virtual int GetClampOverflow()
		{
			return vtkImageCast.vtkImageCast_GetClampOverflow_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageCast_GetOutputScalarType_04(HandleRef pThis);

		public virtual int GetOutputScalarType()
		{
			return vtkImageCast.vtkImageCast_GetOutputScalarType_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageCast_IsA_05(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkImageCast.vtkImageCast_IsA_05(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageCast_IsTypeOf_06(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkImageCast.vtkImageCast_IsTypeOf_06(type);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageCast_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkImageCast NewInstance()
		{
			vtkImageCast result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageCast.vtkImageCast_NewInstance_08(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageCast)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageCast_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkImageCast SafeDownCast(vtkObjectBase o)
		{
			vtkImageCast vtkImageCast = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageCast.vtkImageCast_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageCast = (vtkImageCast)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageCast.Register(null);
				}
			}
			return vtkImageCast;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageCast_SetClampOverflow_10(HandleRef pThis, int _arg);

		public virtual void SetClampOverflow(int _arg)
		{
			vtkImageCast.vtkImageCast_SetClampOverflow_10(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageCast_SetOutputScalarType_11(HandleRef pThis, int _arg);

		public virtual void SetOutputScalarType(int _arg)
		{
			vtkImageCast.vtkImageCast_SetOutputScalarType_11(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageCast_SetOutputScalarTypeToChar_12(HandleRef pThis);

		public void SetOutputScalarTypeToChar()
		{
			vtkImageCast.vtkImageCast_SetOutputScalarTypeToChar_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageCast_SetOutputScalarTypeToDouble_13(HandleRef pThis);

		public void SetOutputScalarTypeToDouble()
		{
			vtkImageCast.vtkImageCast_SetOutputScalarTypeToDouble_13(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageCast_SetOutputScalarTypeToFloat_14(HandleRef pThis);

		public void SetOutputScalarTypeToFloat()
		{
			vtkImageCast.vtkImageCast_SetOutputScalarTypeToFloat_14(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageCast_SetOutputScalarTypeToInt_15(HandleRef pThis);

		public void SetOutputScalarTypeToInt()
		{
			vtkImageCast.vtkImageCast_SetOutputScalarTypeToInt_15(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageCast_SetOutputScalarTypeToLong_16(HandleRef pThis);

		public void SetOutputScalarTypeToLong()
		{
			vtkImageCast.vtkImageCast_SetOutputScalarTypeToLong_16(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageCast_SetOutputScalarTypeToShort_17(HandleRef pThis);

		public void SetOutputScalarTypeToShort()
		{
			vtkImageCast.vtkImageCast_SetOutputScalarTypeToShort_17(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageCast_SetOutputScalarTypeToUnsignedChar_18(HandleRef pThis);

		public void SetOutputScalarTypeToUnsignedChar()
		{
			vtkImageCast.vtkImageCast_SetOutputScalarTypeToUnsignedChar_18(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageCast_SetOutputScalarTypeToUnsignedInt_19(HandleRef pThis);

		public void SetOutputScalarTypeToUnsignedInt()
		{
			vtkImageCast.vtkImageCast_SetOutputScalarTypeToUnsignedInt_19(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageCast_SetOutputScalarTypeToUnsignedLong_20(HandleRef pThis);

		public void SetOutputScalarTypeToUnsignedLong()
		{
			vtkImageCast.vtkImageCast_SetOutputScalarTypeToUnsignedLong_20(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageCast_SetOutputScalarTypeToUnsignedShort_21(HandleRef pThis);

		public void SetOutputScalarTypeToUnsignedShort()
		{
			vtkImageCast.vtkImageCast_SetOutputScalarTypeToUnsignedShort_21(base.GetCppThis());
		}
	}
}
