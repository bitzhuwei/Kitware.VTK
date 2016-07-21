using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkImageRGBToHSV : vtkThreadedImageAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkImageRGBToHSV";

		public new static readonly string MRClassNameKey;

		static vtkImageRGBToHSV()
		{
			vtkImageRGBToHSV.MRClassNameKey = "class vtkImageRGBToHSV";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImageRGBToHSV.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageRGBToHSV"));
		}

		public vtkImageRGBToHSV(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageRGBToHSV_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkImageRGBToHSV New()
		{
			vtkImageRGBToHSV result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageRGBToHSV.vtkImageRGBToHSV_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageRGBToHSV)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkImageRGBToHSV() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkImageRGBToHSV.vtkImageRGBToHSV_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern double vtkImageRGBToHSV_GetMaximum_01(HandleRef pThis);

		public virtual double GetMaximum()
		{
			return vtkImageRGBToHSV.vtkImageRGBToHSV_GetMaximum_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageRGBToHSV_IsA_02(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkImageRGBToHSV.vtkImageRGBToHSV_IsA_02(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageRGBToHSV_IsTypeOf_03(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkImageRGBToHSV.vtkImageRGBToHSV_IsTypeOf_03(type);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageRGBToHSV_NewInstance_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkImageRGBToHSV NewInstance()
		{
			vtkImageRGBToHSV result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageRGBToHSV.vtkImageRGBToHSV_NewInstance_05(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageRGBToHSV)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageRGBToHSV_SafeDownCast_06(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkImageRGBToHSV SafeDownCast(vtkObjectBase o)
		{
			vtkImageRGBToHSV vtkImageRGBToHSV = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageRGBToHSV.vtkImageRGBToHSV_SafeDownCast_06((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageRGBToHSV = (vtkImageRGBToHSV)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageRGBToHSV.Register(null);
				}
			}
			return vtkImageRGBToHSV;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageRGBToHSV_SetMaximum_07(HandleRef pThis, double _arg);

		public virtual void SetMaximum(double _arg)
		{
			vtkImageRGBToHSV.vtkImageRGBToHSV_SetMaximum_07(base.GetCppThis(), _arg);
		}
	}
}
