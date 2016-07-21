using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkImageHSVToRGB : vtkThreadedImageAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkImageHSVToRGB";

		public new static readonly string MRClassNameKey;

		static vtkImageHSVToRGB()
		{
			vtkImageHSVToRGB.MRClassNameKey = "class vtkImageHSVToRGB";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImageHSVToRGB.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageHSVToRGB"));
		}

		public vtkImageHSVToRGB(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageHSVToRGB_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkImageHSVToRGB New()
		{
			vtkImageHSVToRGB result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageHSVToRGB.vtkImageHSVToRGB_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageHSVToRGB)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkImageHSVToRGB() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkImageHSVToRGB.vtkImageHSVToRGB_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern double vtkImageHSVToRGB_GetMaximum_01(HandleRef pThis);

		public virtual double GetMaximum()
		{
			return vtkImageHSVToRGB.vtkImageHSVToRGB_GetMaximum_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageHSVToRGB_IsA_02(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkImageHSVToRGB.vtkImageHSVToRGB_IsA_02(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageHSVToRGB_IsTypeOf_03(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkImageHSVToRGB.vtkImageHSVToRGB_IsTypeOf_03(type);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageHSVToRGB_NewInstance_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkImageHSVToRGB NewInstance()
		{
			vtkImageHSVToRGB result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageHSVToRGB.vtkImageHSVToRGB_NewInstance_05(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageHSVToRGB)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageHSVToRGB_SafeDownCast_06(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkImageHSVToRGB SafeDownCast(vtkObjectBase o)
		{
			vtkImageHSVToRGB vtkImageHSVToRGB = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageHSVToRGB.vtkImageHSVToRGB_SafeDownCast_06((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageHSVToRGB = (vtkImageHSVToRGB)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageHSVToRGB.Register(null);
				}
			}
			return vtkImageHSVToRGB;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageHSVToRGB_SetMaximum_07(HandleRef pThis, double _arg);

		public virtual void SetMaximum(double _arg)
		{
			vtkImageHSVToRGB.vtkImageHSVToRGB_SetMaximum_07(base.GetCppThis(), _arg);
		}
	}
}
