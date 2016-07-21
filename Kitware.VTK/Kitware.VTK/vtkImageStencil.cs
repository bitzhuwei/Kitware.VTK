using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkImageStencil : vtkThreadedImageAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkImageStencil";

		public new static readonly string MRClassNameKey;

		static vtkImageStencil()
		{
			vtkImageStencil.MRClassNameKey = "class vtkImageStencil";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImageStencil.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageStencil"));
		}

		public vtkImageStencil(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageStencil_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkImageStencil New()
		{
			vtkImageStencil result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageStencil.vtkImageStencil_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageStencil)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkImageStencil() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkImageStencil.vtkImageStencil_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageStencil_GetBackgroundColor_01(HandleRef pThis);

		public virtual double[] GetBackgroundColor()
		{
			IntPtr intPtr = vtkImageStencil.vtkImageStencil_GetBackgroundColor_01(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[4];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageStencil_GetBackgroundColor_02(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3, ref double _arg4);

		public virtual void GetBackgroundColor(ref double _arg1, ref double _arg2, ref double _arg3, ref double _arg4)
		{
			vtkImageStencil.vtkImageStencil_GetBackgroundColor_02(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3, ref _arg4);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageStencil_GetBackgroundColor_03(HandleRef pThis, IntPtr _arg);

		public virtual void GetBackgroundColor(IntPtr _arg)
		{
			vtkImageStencil.vtkImageStencil_GetBackgroundColor_03(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageStencil_GetBackgroundInput_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkImageData GetBackgroundInput()
		{
			vtkImageData vtkImageData = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageStencil.vtkImageStencil_GetBackgroundInput_04(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern double vtkImageStencil_GetBackgroundValue_05(HandleRef pThis);

		public double GetBackgroundValue()
		{
			return vtkImageStencil.vtkImageStencil_GetBackgroundValue_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageStencil_GetReverseStencil_06(HandleRef pThis);

		public virtual int GetReverseStencil()
		{
			return vtkImageStencil.vtkImageStencil_GetReverseStencil_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageStencil_GetStencil_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkImageStencilData GetStencil()
		{
			vtkImageStencilData vtkImageStencilData = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageStencil.vtkImageStencil_GetStencil_07(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageStencilData = (vtkImageStencilData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageStencilData.Register(null);
				}
			}
			return vtkImageStencilData;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageStencil_IsA_08(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkImageStencil.vtkImageStencil_IsA_08(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageStencil_IsTypeOf_09(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkImageStencil.vtkImageStencil_IsTypeOf_09(type);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageStencil_NewInstance_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkImageStencil NewInstance()
		{
			vtkImageStencil result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageStencil.vtkImageStencil_NewInstance_11(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageStencil)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageStencil_ReverseStencilOff_12(HandleRef pThis);

		public virtual void ReverseStencilOff()
		{
			vtkImageStencil.vtkImageStencil_ReverseStencilOff_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageStencil_ReverseStencilOn_13(HandleRef pThis);

		public virtual void ReverseStencilOn()
		{
			vtkImageStencil.vtkImageStencil_ReverseStencilOn_13(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageStencil_SafeDownCast_14(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkImageStencil SafeDownCast(vtkObjectBase o)
		{
			vtkImageStencil vtkImageStencil = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageStencil.vtkImageStencil_SafeDownCast_14((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageStencil = (vtkImageStencil)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageStencil.Register(null);
				}
			}
			return vtkImageStencil;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageStencil_SetBackgroundColor_15(HandleRef pThis, double _arg1, double _arg2, double _arg3, double _arg4);

		public virtual void SetBackgroundColor(double _arg1, double _arg2, double _arg3, double _arg4)
		{
			vtkImageStencil.vtkImageStencil_SetBackgroundColor_15(base.GetCppThis(), _arg1, _arg2, _arg3, _arg4);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageStencil_SetBackgroundColor_16(HandleRef pThis, IntPtr _arg);

		public virtual void SetBackgroundColor(IntPtr _arg)
		{
			vtkImageStencil.vtkImageStencil_SetBackgroundColor_16(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageStencil_SetBackgroundInput_17(HandleRef pThis, HandleRef input);

		public virtual void SetBackgroundInput(vtkImageData input)
		{
			vtkImageStencil.vtkImageStencil_SetBackgroundInput_17(base.GetCppThis(), (input == null) ? default(HandleRef) : input.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageStencil_SetBackgroundValue_18(HandleRef pThis, double val);

		public void SetBackgroundValue(double val)
		{
			vtkImageStencil.vtkImageStencil_SetBackgroundValue_18(base.GetCppThis(), val);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageStencil_SetReverseStencil_19(HandleRef pThis, int _arg);

		public virtual void SetReverseStencil(int _arg)
		{
			vtkImageStencil.vtkImageStencil_SetReverseStencil_19(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageStencil_SetStencil_20(HandleRef pThis, HandleRef stencil);

		public virtual void SetStencil(vtkImageStencilData stencil)
		{
			vtkImageStencil.vtkImageStencil_SetStencil_20(base.GetCppThis(), (stencil == null) ? default(HandleRef) : stencil.GetCppThis());
		}
	}
}
