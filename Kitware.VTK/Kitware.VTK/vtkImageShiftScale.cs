using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkImageShiftScale : vtkThreadedImageAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkImageShiftScale";

		public new static readonly string MRClassNameKey;

		static vtkImageShiftScale()
		{
			vtkImageShiftScale.MRClassNameKey = "class vtkImageShiftScale";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImageShiftScale.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageShiftScale"));
		}

		public vtkImageShiftScale(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageShiftScale_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkImageShiftScale New()
		{
			vtkImageShiftScale result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageShiftScale.vtkImageShiftScale_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageShiftScale)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkImageShiftScale() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkImageShiftScale.vtkImageShiftScale_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageShiftScale_ClampOverflowOff_01(HandleRef pThis);

		public virtual void ClampOverflowOff()
		{
			vtkImageShiftScale.vtkImageShiftScale_ClampOverflowOff_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageShiftScale_ClampOverflowOn_02(HandleRef pThis);

		public virtual void ClampOverflowOn()
		{
			vtkImageShiftScale.vtkImageShiftScale_ClampOverflowOn_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageShiftScale_GetClampOverflow_03(HandleRef pThis);

		public virtual int GetClampOverflow()
		{
			return vtkImageShiftScale.vtkImageShiftScale_GetClampOverflow_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageShiftScale_GetOutputScalarType_04(HandleRef pThis);

		public virtual int GetOutputScalarType()
		{
			return vtkImageShiftScale.vtkImageShiftScale_GetOutputScalarType_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern double vtkImageShiftScale_GetScale_05(HandleRef pThis);

		public virtual double GetScale()
		{
			return vtkImageShiftScale.vtkImageShiftScale_GetScale_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern double vtkImageShiftScale_GetShift_06(HandleRef pThis);

		public virtual double GetShift()
		{
			return vtkImageShiftScale.vtkImageShiftScale_GetShift_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageShiftScale_IsA_07(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkImageShiftScale.vtkImageShiftScale_IsA_07(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageShiftScale_IsTypeOf_08(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkImageShiftScale.vtkImageShiftScale_IsTypeOf_08(type);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageShiftScale_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkImageShiftScale NewInstance()
		{
			vtkImageShiftScale result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageShiftScale.vtkImageShiftScale_NewInstance_10(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageShiftScale)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageShiftScale_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkImageShiftScale SafeDownCast(vtkObjectBase o)
		{
			vtkImageShiftScale vtkImageShiftScale = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageShiftScale.vtkImageShiftScale_SafeDownCast_11((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageShiftScale = (vtkImageShiftScale)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageShiftScale.Register(null);
				}
			}
			return vtkImageShiftScale;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageShiftScale_SetClampOverflow_12(HandleRef pThis, int _arg);

		public virtual void SetClampOverflow(int _arg)
		{
			vtkImageShiftScale.vtkImageShiftScale_SetClampOverflow_12(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageShiftScale_SetOutputScalarType_13(HandleRef pThis, int _arg);

		public virtual void SetOutputScalarType(int _arg)
		{
			vtkImageShiftScale.vtkImageShiftScale_SetOutputScalarType_13(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageShiftScale_SetOutputScalarTypeToChar_14(HandleRef pThis);

		public void SetOutputScalarTypeToChar()
		{
			vtkImageShiftScale.vtkImageShiftScale_SetOutputScalarTypeToChar_14(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageShiftScale_SetOutputScalarTypeToDouble_15(HandleRef pThis);

		public void SetOutputScalarTypeToDouble()
		{
			vtkImageShiftScale.vtkImageShiftScale_SetOutputScalarTypeToDouble_15(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageShiftScale_SetOutputScalarTypeToFloat_16(HandleRef pThis);

		public void SetOutputScalarTypeToFloat()
		{
			vtkImageShiftScale.vtkImageShiftScale_SetOutputScalarTypeToFloat_16(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageShiftScale_SetOutputScalarTypeToInt_17(HandleRef pThis);

		public void SetOutputScalarTypeToInt()
		{
			vtkImageShiftScale.vtkImageShiftScale_SetOutputScalarTypeToInt_17(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageShiftScale_SetOutputScalarTypeToLong_18(HandleRef pThis);

		public void SetOutputScalarTypeToLong()
		{
			vtkImageShiftScale.vtkImageShiftScale_SetOutputScalarTypeToLong_18(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageShiftScale_SetOutputScalarTypeToShort_19(HandleRef pThis);

		public void SetOutputScalarTypeToShort()
		{
			vtkImageShiftScale.vtkImageShiftScale_SetOutputScalarTypeToShort_19(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageShiftScale_SetOutputScalarTypeToUnsignedChar_20(HandleRef pThis);

		public void SetOutputScalarTypeToUnsignedChar()
		{
			vtkImageShiftScale.vtkImageShiftScale_SetOutputScalarTypeToUnsignedChar_20(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageShiftScale_SetOutputScalarTypeToUnsignedInt_21(HandleRef pThis);

		public void SetOutputScalarTypeToUnsignedInt()
		{
			vtkImageShiftScale.vtkImageShiftScale_SetOutputScalarTypeToUnsignedInt_21(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageShiftScale_SetOutputScalarTypeToUnsignedLong_22(HandleRef pThis);

		public void SetOutputScalarTypeToUnsignedLong()
		{
			vtkImageShiftScale.vtkImageShiftScale_SetOutputScalarTypeToUnsignedLong_22(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageShiftScale_SetOutputScalarTypeToUnsignedShort_23(HandleRef pThis);

		public void SetOutputScalarTypeToUnsignedShort()
		{
			vtkImageShiftScale.vtkImageShiftScale_SetOutputScalarTypeToUnsignedShort_23(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageShiftScale_SetScale_24(HandleRef pThis, double _arg);

		public virtual void SetScale(double _arg)
		{
			vtkImageShiftScale.vtkImageShiftScale_SetScale_24(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageShiftScale_SetShift_25(HandleRef pThis, double _arg);

		public virtual void SetShift(double _arg)
		{
			vtkImageShiftScale.vtkImageShiftScale_SetShift_25(base.GetCppThis(), _arg);
		}
	}
}
