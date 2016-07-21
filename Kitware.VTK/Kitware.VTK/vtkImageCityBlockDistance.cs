using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkImageCityBlockDistance : vtkImageDecomposeFilter
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkImageCityBlockDistance";

		public new static readonly string MRClassNameKey;

		static vtkImageCityBlockDistance()
		{
			vtkImageCityBlockDistance.MRClassNameKey = "class vtkImageCityBlockDistance";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImageCityBlockDistance.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageCityBlockDistance"));
		}

		public vtkImageCityBlockDistance(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageCityBlockDistance_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkImageCityBlockDistance New()
		{
			vtkImageCityBlockDistance result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageCityBlockDistance.vtkImageCityBlockDistance_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageCityBlockDistance)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkImageCityBlockDistance() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkImageCityBlockDistance.vtkImageCityBlockDistance_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageCityBlockDistance_IsA_01(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkImageCityBlockDistance.vtkImageCityBlockDistance_IsA_01(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageCityBlockDistance_IsTypeOf_02(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkImageCityBlockDistance.vtkImageCityBlockDistance_IsTypeOf_02(type);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageCityBlockDistance_NewInstance_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkImageCityBlockDistance NewInstance()
		{
			vtkImageCityBlockDistance result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageCityBlockDistance.vtkImageCityBlockDistance_NewInstance_04(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageCityBlockDistance)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageCityBlockDistance_SafeDownCast_05(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkImageCityBlockDistance SafeDownCast(vtkObjectBase o)
		{
			vtkImageCityBlockDistance vtkImageCityBlockDistance = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageCityBlockDistance.vtkImageCityBlockDistance_SafeDownCast_05((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageCityBlockDistance = (vtkImageCityBlockDistance)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageCityBlockDistance.Register(null);
				}
			}
			return vtkImageCityBlockDistance;
		}
	}
}
