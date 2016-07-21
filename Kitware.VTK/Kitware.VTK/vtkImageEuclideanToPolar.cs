using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkImageEuclideanToPolar : vtkThreadedImageAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkImageEuclideanToPolar";

		public new static readonly string MRClassNameKey;

		static vtkImageEuclideanToPolar()
		{
			vtkImageEuclideanToPolar.MRClassNameKey = "class vtkImageEuclideanToPolar";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImageEuclideanToPolar.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageEuclideanToPolar"));
		}

		public vtkImageEuclideanToPolar(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageEuclideanToPolar_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkImageEuclideanToPolar New()
		{
			vtkImageEuclideanToPolar result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageEuclideanToPolar.vtkImageEuclideanToPolar_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageEuclideanToPolar)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkImageEuclideanToPolar() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkImageEuclideanToPolar.vtkImageEuclideanToPolar_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern double vtkImageEuclideanToPolar_GetThetaMaximum_01(HandleRef pThis);

		public virtual double GetThetaMaximum()
		{
			return vtkImageEuclideanToPolar.vtkImageEuclideanToPolar_GetThetaMaximum_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageEuclideanToPolar_IsA_02(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkImageEuclideanToPolar.vtkImageEuclideanToPolar_IsA_02(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageEuclideanToPolar_IsTypeOf_03(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkImageEuclideanToPolar.vtkImageEuclideanToPolar_IsTypeOf_03(type);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageEuclideanToPolar_NewInstance_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkImageEuclideanToPolar NewInstance()
		{
			vtkImageEuclideanToPolar result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageEuclideanToPolar.vtkImageEuclideanToPolar_NewInstance_05(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageEuclideanToPolar)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageEuclideanToPolar_SafeDownCast_06(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkImageEuclideanToPolar SafeDownCast(vtkObjectBase o)
		{
			vtkImageEuclideanToPolar vtkImageEuclideanToPolar = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageEuclideanToPolar.vtkImageEuclideanToPolar_SafeDownCast_06((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageEuclideanToPolar = (vtkImageEuclideanToPolar)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageEuclideanToPolar.Register(null);
				}
			}
			return vtkImageEuclideanToPolar;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageEuclideanToPolar_SetThetaMaximum_07(HandleRef pThis, double _arg);

		public virtual void SetThetaMaximum(double _arg)
		{
			vtkImageEuclideanToPolar.vtkImageEuclideanToPolar_SetThetaMaximum_07(base.GetCppThis(), _arg);
		}
	}
}
