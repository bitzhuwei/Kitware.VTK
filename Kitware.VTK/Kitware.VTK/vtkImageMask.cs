using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkImageMask : vtkThreadedImageAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkImageMask";

		public new static readonly string MRClassNameKey;

		static vtkImageMask()
		{
			vtkImageMask.MRClassNameKey = "class vtkImageMask";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImageMask.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageMask"));
		}

		public vtkImageMask(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageMask_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkImageMask New()
		{
			vtkImageMask result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageMask.vtkImageMask_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageMask)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkImageMask() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkImageMask.vtkImageMask_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern double vtkImageMask_GetMaskAlpha_01(HandleRef pThis);

		public virtual double GetMaskAlpha()
		{
			return vtkImageMask.vtkImageMask_GetMaskAlpha_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern double vtkImageMask_GetMaskAlphaMaxValue_02(HandleRef pThis);

		public virtual double GetMaskAlphaMaxValue()
		{
			return vtkImageMask.vtkImageMask_GetMaskAlphaMaxValue_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern double vtkImageMask_GetMaskAlphaMinValue_03(HandleRef pThis);

		public virtual double GetMaskAlphaMinValue()
		{
			return vtkImageMask.vtkImageMask_GetMaskAlphaMinValue_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageMask_GetMaskedOutputValue_04(HandleRef pThis);

		public IntPtr GetMaskedOutputValue()
		{
			return vtkImageMask.vtkImageMask_GetMaskedOutputValue_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageMask_GetMaskedOutputValueLength_05(HandleRef pThis);

		public int GetMaskedOutputValueLength()
		{
			return vtkImageMask.vtkImageMask_GetMaskedOutputValueLength_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageMask_GetNotMask_06(HandleRef pThis);

		public virtual int GetNotMask()
		{
			return vtkImageMask.vtkImageMask_GetNotMask_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageMask_IsA_07(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkImageMask.vtkImageMask_IsA_07(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageMask_IsTypeOf_08(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkImageMask.vtkImageMask_IsTypeOf_08(type);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageMask_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkImageMask NewInstance()
		{
			vtkImageMask result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageMask.vtkImageMask_NewInstance_10(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageMask)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageMask_NotMaskOff_11(HandleRef pThis);

		public virtual void NotMaskOff()
		{
			vtkImageMask.vtkImageMask_NotMaskOff_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageMask_NotMaskOn_12(HandleRef pThis);

		public virtual void NotMaskOn()
		{
			vtkImageMask.vtkImageMask_NotMaskOn_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageMask_SafeDownCast_13(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkImageMask SafeDownCast(vtkObjectBase o)
		{
			vtkImageMask vtkImageMask = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageMask.vtkImageMask_SafeDownCast_13((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageMask = (vtkImageMask)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageMask.Register(null);
				}
			}
			return vtkImageMask;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageMask_SetImageInput_14(HandleRef pThis, HandleRef arg0);

		public void SetImageInput(vtkImageData arg0)
		{
			vtkImageMask.vtkImageMask_SetImageInput_14(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageMask_SetInput1_15(HandleRef pThis, HandleRef arg0);

		public virtual void SetInput1(vtkDataObject arg0)
		{
			vtkImageMask.vtkImageMask_SetInput1_15(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageMask_SetInput2_16(HandleRef pThis, HandleRef arg0);

		public virtual void SetInput2(vtkDataObject arg0)
		{
			vtkImageMask.vtkImageMask_SetInput2_16(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageMask_SetMaskAlpha_17(HandleRef pThis, double _arg);

		public virtual void SetMaskAlpha(double _arg)
		{
			vtkImageMask.vtkImageMask_SetMaskAlpha_17(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageMask_SetMaskInput_18(HandleRef pThis, HandleRef arg0);

		public void SetMaskInput(vtkImageData arg0)
		{
			vtkImageMask.vtkImageMask_SetMaskInput_18(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageMask_SetMaskedOutputValue_19(HandleRef pThis, int num, IntPtr v);

		public void SetMaskedOutputValue(int num, IntPtr v)
		{
			vtkImageMask.vtkImageMask_SetMaskedOutputValue_19(base.GetCppThis(), num, v);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageMask_SetMaskedOutputValue_20(HandleRef pThis, double v);

		public void SetMaskedOutputValue(double v)
		{
			vtkImageMask.vtkImageMask_SetMaskedOutputValue_20(base.GetCppThis(), v);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageMask_SetMaskedOutputValue_21(HandleRef pThis, double v1, double v2);

		public void SetMaskedOutputValue(double v1, double v2)
		{
			vtkImageMask.vtkImageMask_SetMaskedOutputValue_21(base.GetCppThis(), v1, v2);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageMask_SetMaskedOutputValue_22(HandleRef pThis, double v1, double v2, double v3);

		public void SetMaskedOutputValue(double v1, double v2, double v3)
		{
			vtkImageMask.vtkImageMask_SetMaskedOutputValue_22(base.GetCppThis(), v1, v2, v3);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageMask_SetNotMask_23(HandleRef pThis, int _arg);

		public virtual void SetNotMask(int _arg)
		{
			vtkImageMask.vtkImageMask_SetNotMask_23(base.GetCppThis(), _arg);
		}
	}
}
