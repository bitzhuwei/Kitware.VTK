using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkFixedPointVolumeRayCastHelper : vtkObject
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkFixedPointVolumeRayCastHelper";

		public new static readonly string MRClassNameKey;

		static vtkFixedPointVolumeRayCastHelper()
		{
			vtkFixedPointVolumeRayCastHelper.MRClassNameKey = "class vtkFixedPointVolumeRayCastHelper";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkFixedPointVolumeRayCastHelper.MRClassNameKey, Type.GetType("Kitware.VTK.vtkFixedPointVolumeRayCastHelper"));
		}

		public vtkFixedPointVolumeRayCastHelper(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkFixedPointVolumeRayCastHelper_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkFixedPointVolumeRayCastHelper New()
		{
			vtkFixedPointVolumeRayCastHelper result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkFixedPointVolumeRayCastHelper.vtkFixedPointVolumeRayCastHelper_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkFixedPointVolumeRayCastHelper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkFixedPointVolumeRayCastHelper() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkFixedPointVolumeRayCastHelper.vtkFixedPointVolumeRayCastHelper_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkFixedPointVolumeRayCastHelper_GenerateImage_01(HandleRef pThis, int arg0, int arg1, HandleRef arg2, HandleRef arg3);

		public virtual void GenerateImage(int arg0, int arg1, vtkVolume arg2, vtkFixedPointVolumeRayCastMapper arg3)
		{
			vtkFixedPointVolumeRayCastHelper.vtkFixedPointVolumeRayCastHelper_GenerateImage_01(base.GetCppThis(), arg0, arg1, (arg2 == null) ? default(HandleRef) : arg2.GetCppThis(), (arg3 == null) ? default(HandleRef) : arg3.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkFixedPointVolumeRayCastHelper_IsA_02(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkFixedPointVolumeRayCastHelper.vtkFixedPointVolumeRayCastHelper_IsA_02(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkFixedPointVolumeRayCastHelper_IsTypeOf_03(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkFixedPointVolumeRayCastHelper.vtkFixedPointVolumeRayCastHelper_IsTypeOf_03(type);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkFixedPointVolumeRayCastHelper_NewInstance_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkFixedPointVolumeRayCastHelper NewInstance()
		{
			vtkFixedPointVolumeRayCastHelper result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkFixedPointVolumeRayCastHelper.vtkFixedPointVolumeRayCastHelper_NewInstance_05(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkFixedPointVolumeRayCastHelper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkFixedPointVolumeRayCastHelper_SafeDownCast_06(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkFixedPointVolumeRayCastHelper SafeDownCast(vtkObjectBase o)
		{
			vtkFixedPointVolumeRayCastHelper vtkFixedPointVolumeRayCastHelper = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkFixedPointVolumeRayCastHelper.vtkFixedPointVolumeRayCastHelper_SafeDownCast_06((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkFixedPointVolumeRayCastHelper = (vtkFixedPointVolumeRayCastHelper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkFixedPointVolumeRayCastHelper.Register(null);
				}
			}
			return vtkFixedPointVolumeRayCastHelper;
		}
	}
}
