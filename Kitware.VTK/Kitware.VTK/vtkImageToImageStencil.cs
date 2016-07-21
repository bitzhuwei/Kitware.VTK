using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkImageToImageStencil : vtkImageStencilAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkImageToImageStencil";

		public new static readonly string MRClassNameKey;

		static vtkImageToImageStencil()
		{
			vtkImageToImageStencil.MRClassNameKey = "class vtkImageToImageStencil";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImageToImageStencil.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageToImageStencil"));
		}

		public vtkImageToImageStencil(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageToImageStencil_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkImageToImageStencil New()
		{
			vtkImageToImageStencil result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageToImageStencil.vtkImageToImageStencil_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageToImageStencil)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkImageToImageStencil() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkImageToImageStencil.vtkImageToImageStencil_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageToImageStencil_GetInput_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkImageData GetInput()
		{
			vtkImageData vtkImageData = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageToImageStencil.vtkImageToImageStencil_GetInput_01(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern double vtkImageToImageStencil_GetLowerThreshold_02(HandleRef pThis);

		public virtual double GetLowerThreshold()
		{
			return vtkImageToImageStencil.vtkImageToImageStencil_GetLowerThreshold_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern double vtkImageToImageStencil_GetUpperThreshold_03(HandleRef pThis);

		public virtual double GetUpperThreshold()
		{
			return vtkImageToImageStencil.vtkImageToImageStencil_GetUpperThreshold_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageToImageStencil_IsA_04(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkImageToImageStencil.vtkImageToImageStencil_IsA_04(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageToImageStencil_IsTypeOf_05(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkImageToImageStencil.vtkImageToImageStencil_IsTypeOf_05(type);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageToImageStencil_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkImageToImageStencil NewInstance()
		{
			vtkImageToImageStencil result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageToImageStencil.vtkImageToImageStencil_NewInstance_07(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageToImageStencil)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageToImageStencil_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkImageToImageStencil SafeDownCast(vtkObjectBase o)
		{
			vtkImageToImageStencil vtkImageToImageStencil = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageToImageStencil.vtkImageToImageStencil_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageToImageStencil = (vtkImageToImageStencil)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageToImageStencil.Register(null);
				}
			}
			return vtkImageToImageStencil;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageToImageStencil_SetInput_09(HandleRef pThis, HandleRef input);

		public void SetInput(vtkImageData input)
		{
			vtkImageToImageStencil.vtkImageToImageStencil_SetInput_09(base.GetCppThis(), (input == null) ? default(HandleRef) : input.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageToImageStencil_SetLowerThreshold_10(HandleRef pThis, double _arg);

		public virtual void SetLowerThreshold(double _arg)
		{
			vtkImageToImageStencil.vtkImageToImageStencil_SetLowerThreshold_10(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageToImageStencil_SetUpperThreshold_11(HandleRef pThis, double _arg);

		public virtual void SetUpperThreshold(double _arg)
		{
			vtkImageToImageStencil.vtkImageToImageStencil_SetUpperThreshold_11(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageToImageStencil_ThresholdBetween_12(HandleRef pThis, double lower, double upper);

		public void ThresholdBetween(double lower, double upper)
		{
			vtkImageToImageStencil.vtkImageToImageStencil_ThresholdBetween_12(base.GetCppThis(), lower, upper);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageToImageStencil_ThresholdByLower_13(HandleRef pThis, double thresh);

		public void ThresholdByLower(double thresh)
		{
			vtkImageToImageStencil.vtkImageToImageStencil_ThresholdByLower_13(base.GetCppThis(), thresh);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageToImageStencil_ThresholdByUpper_14(HandleRef pThis, double thresh);

		public void ThresholdByUpper(double thresh)
		{
			vtkImageToImageStencil.vtkImageToImageStencil_ThresholdByUpper_14(base.GetCppThis(), thresh);
		}
	}
}
