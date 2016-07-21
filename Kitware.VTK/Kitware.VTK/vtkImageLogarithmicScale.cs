using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkImageLogarithmicScale : vtkThreadedImageAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkImageLogarithmicScale";

		public new static readonly string MRClassNameKey;

		static vtkImageLogarithmicScale()
		{
			vtkImageLogarithmicScale.MRClassNameKey = "class vtkImageLogarithmicScale";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImageLogarithmicScale.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageLogarithmicScale"));
		}

		public vtkImageLogarithmicScale(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageLogarithmicScale_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkImageLogarithmicScale New()
		{
			vtkImageLogarithmicScale result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageLogarithmicScale.vtkImageLogarithmicScale_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageLogarithmicScale)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkImageLogarithmicScale() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkImageLogarithmicScale.vtkImageLogarithmicScale_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern double vtkImageLogarithmicScale_GetConstant_01(HandleRef pThis);

		public virtual double GetConstant()
		{
			return vtkImageLogarithmicScale.vtkImageLogarithmicScale_GetConstant_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageLogarithmicScale_IsA_02(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkImageLogarithmicScale.vtkImageLogarithmicScale_IsA_02(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageLogarithmicScale_IsTypeOf_03(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkImageLogarithmicScale.vtkImageLogarithmicScale_IsTypeOf_03(type);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageLogarithmicScale_NewInstance_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkImageLogarithmicScale NewInstance()
		{
			vtkImageLogarithmicScale result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageLogarithmicScale.vtkImageLogarithmicScale_NewInstance_05(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageLogarithmicScale)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageLogarithmicScale_SafeDownCast_06(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkImageLogarithmicScale SafeDownCast(vtkObjectBase o)
		{
			vtkImageLogarithmicScale vtkImageLogarithmicScale = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageLogarithmicScale.vtkImageLogarithmicScale_SafeDownCast_06((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageLogarithmicScale = (vtkImageLogarithmicScale)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageLogarithmicScale.Register(null);
				}
			}
			return vtkImageLogarithmicScale;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageLogarithmicScale_SetConstant_07(HandleRef pThis, double _arg);

		public virtual void SetConstant(double _arg)
		{
			vtkImageLogarithmicScale.vtkImageLogarithmicScale_SetConstant_07(base.GetCppThis(), _arg);
		}
	}
}
