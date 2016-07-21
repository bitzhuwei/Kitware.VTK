using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkImageHSIToRGB : vtkThreadedImageAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkImageHSIToRGB";

		public new static readonly string MRClassNameKey;

		static vtkImageHSIToRGB()
		{
			vtkImageHSIToRGB.MRClassNameKey = "class vtkImageHSIToRGB";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImageHSIToRGB.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageHSIToRGB"));
		}

		public vtkImageHSIToRGB(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageHSIToRGB_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkImageHSIToRGB New()
		{
			vtkImageHSIToRGB result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageHSIToRGB.vtkImageHSIToRGB_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageHSIToRGB)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkImageHSIToRGB() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkImageHSIToRGB.vtkImageHSIToRGB_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern double vtkImageHSIToRGB_GetMaximum_01(HandleRef pThis);

		public virtual double GetMaximum()
		{
			return vtkImageHSIToRGB.vtkImageHSIToRGB_GetMaximum_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageHSIToRGB_IsA_02(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkImageHSIToRGB.vtkImageHSIToRGB_IsA_02(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageHSIToRGB_IsTypeOf_03(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkImageHSIToRGB.vtkImageHSIToRGB_IsTypeOf_03(type);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageHSIToRGB_NewInstance_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkImageHSIToRGB NewInstance()
		{
			vtkImageHSIToRGB result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageHSIToRGB.vtkImageHSIToRGB_NewInstance_05(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageHSIToRGB)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageHSIToRGB_SafeDownCast_06(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkImageHSIToRGB SafeDownCast(vtkObjectBase o)
		{
			vtkImageHSIToRGB vtkImageHSIToRGB = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageHSIToRGB.vtkImageHSIToRGB_SafeDownCast_06((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageHSIToRGB = (vtkImageHSIToRGB)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageHSIToRGB.Register(null);
				}
			}
			return vtkImageHSIToRGB;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageHSIToRGB_SetMaximum_07(HandleRef pThis, double _arg);

		public virtual void SetMaximum(double _arg)
		{
			vtkImageHSIToRGB.vtkImageHSIToRGB_SetMaximum_07(base.GetCppThis(), _arg);
		}
	}
}
