using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkImageRGBToHSI : vtkThreadedImageAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkImageRGBToHSI";

		public new static readonly string MRClassNameKey;

		static vtkImageRGBToHSI()
		{
			vtkImageRGBToHSI.MRClassNameKey = "class vtkImageRGBToHSI";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImageRGBToHSI.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageRGBToHSI"));
		}

		public vtkImageRGBToHSI(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageRGBToHSI_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkImageRGBToHSI New()
		{
			vtkImageRGBToHSI result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageRGBToHSI.vtkImageRGBToHSI_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageRGBToHSI)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkImageRGBToHSI() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkImageRGBToHSI.vtkImageRGBToHSI_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern double vtkImageRGBToHSI_GetMaximum_01(HandleRef pThis);

		public virtual double GetMaximum()
		{
			return vtkImageRGBToHSI.vtkImageRGBToHSI_GetMaximum_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageRGBToHSI_IsA_02(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkImageRGBToHSI.vtkImageRGBToHSI_IsA_02(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageRGBToHSI_IsTypeOf_03(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkImageRGBToHSI.vtkImageRGBToHSI_IsTypeOf_03(type);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageRGBToHSI_NewInstance_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkImageRGBToHSI NewInstance()
		{
			vtkImageRGBToHSI result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageRGBToHSI.vtkImageRGBToHSI_NewInstance_05(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageRGBToHSI)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageRGBToHSI_SafeDownCast_06(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkImageRGBToHSI SafeDownCast(vtkObjectBase o)
		{
			vtkImageRGBToHSI vtkImageRGBToHSI = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageRGBToHSI.vtkImageRGBToHSI_SafeDownCast_06((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageRGBToHSI = (vtkImageRGBToHSI)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageRGBToHSI.Register(null);
				}
			}
			return vtkImageRGBToHSI;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageRGBToHSI_SetMaximum_07(HandleRef pThis, double _arg);

		public virtual void SetMaximum(double _arg)
		{
			vtkImageRGBToHSI.vtkImageRGBToHSI_SetMaximum_07(base.GetCppThis(), _arg);
		}
	}
}
