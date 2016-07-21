using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkFixedPointVolumeRayCastCompositeHelper : vtkFixedPointVolumeRayCastHelper
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkFixedPointVolumeRayCastCompositeHelper";

		public new static readonly string MRClassNameKey;

		static vtkFixedPointVolumeRayCastCompositeHelper()
		{
			vtkFixedPointVolumeRayCastCompositeHelper.MRClassNameKey = "class vtkFixedPointVolumeRayCastCompositeHelper";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkFixedPointVolumeRayCastCompositeHelper.MRClassNameKey, Type.GetType("Kitware.VTK.vtkFixedPointVolumeRayCastCompositeHelper"));
		}

		public vtkFixedPointVolumeRayCastCompositeHelper(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkFixedPointVolumeRayCastCompositeHelper_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkFixedPointVolumeRayCastCompositeHelper New()
		{
			vtkFixedPointVolumeRayCastCompositeHelper result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkFixedPointVolumeRayCastCompositeHelper.vtkFixedPointVolumeRayCastCompositeHelper_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkFixedPointVolumeRayCastCompositeHelper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkFixedPointVolumeRayCastCompositeHelper() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkFixedPointVolumeRayCastCompositeHelper.vtkFixedPointVolumeRayCastCompositeHelper_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkFixedPointVolumeRayCastCompositeHelper_GenerateImage_01(HandleRef pThis, int threadID, int threadCount, HandleRef vol, HandleRef mapper);

		public override void GenerateImage(int threadID, int threadCount, vtkVolume vol, vtkFixedPointVolumeRayCastMapper mapper)
		{
			vtkFixedPointVolumeRayCastCompositeHelper.vtkFixedPointVolumeRayCastCompositeHelper_GenerateImage_01(base.GetCppThis(), threadID, threadCount, (vol == null) ? default(HandleRef) : vol.GetCppThis(), (mapper == null) ? default(HandleRef) : mapper.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkFixedPointVolumeRayCastCompositeHelper_IsA_02(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkFixedPointVolumeRayCastCompositeHelper.vtkFixedPointVolumeRayCastCompositeHelper_IsA_02(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkFixedPointVolumeRayCastCompositeHelper_IsTypeOf_03(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkFixedPointVolumeRayCastCompositeHelper.vtkFixedPointVolumeRayCastCompositeHelper_IsTypeOf_03(type);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkFixedPointVolumeRayCastCompositeHelper_NewInstance_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkFixedPointVolumeRayCastCompositeHelper NewInstance()
		{
			vtkFixedPointVolumeRayCastCompositeHelper result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkFixedPointVolumeRayCastCompositeHelper.vtkFixedPointVolumeRayCastCompositeHelper_NewInstance_05(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkFixedPointVolumeRayCastCompositeHelper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkFixedPointVolumeRayCastCompositeHelper_SafeDownCast_06(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkFixedPointVolumeRayCastCompositeHelper SafeDownCast(vtkObjectBase o)
		{
			vtkFixedPointVolumeRayCastCompositeHelper vtkFixedPointVolumeRayCastCompositeHelper = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkFixedPointVolumeRayCastCompositeHelper.vtkFixedPointVolumeRayCastCompositeHelper_SafeDownCast_06((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkFixedPointVolumeRayCastCompositeHelper = (vtkFixedPointVolumeRayCastCompositeHelper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkFixedPointVolumeRayCastCompositeHelper.Register(null);
				}
			}
			return vtkFixedPointVolumeRayCastCompositeHelper;
		}
	}
}
