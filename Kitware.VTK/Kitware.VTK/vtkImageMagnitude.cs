using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkImageMagnitude : vtkThreadedImageAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkImageMagnitude";

		public new static readonly string MRClassNameKey;

		static vtkImageMagnitude()
		{
			vtkImageMagnitude.MRClassNameKey = "class vtkImageMagnitude";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImageMagnitude.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageMagnitude"));
		}

		public vtkImageMagnitude(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageMagnitude_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkImageMagnitude New()
		{
			vtkImageMagnitude result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageMagnitude.vtkImageMagnitude_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageMagnitude)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkImageMagnitude() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkImageMagnitude.vtkImageMagnitude_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageMagnitude_IsA_01(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkImageMagnitude.vtkImageMagnitude_IsA_01(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageMagnitude_IsTypeOf_02(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkImageMagnitude.vtkImageMagnitude_IsTypeOf_02(type);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageMagnitude_NewInstance_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkImageMagnitude NewInstance()
		{
			vtkImageMagnitude result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageMagnitude.vtkImageMagnitude_NewInstance_04(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageMagnitude)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageMagnitude_SafeDownCast_05(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkImageMagnitude SafeDownCast(vtkObjectBase o)
		{
			vtkImageMagnitude vtkImageMagnitude = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageMagnitude.vtkImageMagnitude_SafeDownCast_05((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageMagnitude = (vtkImageMagnitude)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageMagnitude.Register(null);
				}
			}
			return vtkImageMagnitude;
		}
	}
}
