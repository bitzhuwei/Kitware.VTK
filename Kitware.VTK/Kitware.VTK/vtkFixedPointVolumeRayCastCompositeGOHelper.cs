using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkFixedPointVolumeRayCastCompositeGOHelper : vtkFixedPointVolumeRayCastHelper
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkFixedPointVolumeRayCastCompositeGOHelper";

		public new static readonly string MRClassNameKey;

		static vtkFixedPointVolumeRayCastCompositeGOHelper()
		{
			vtkFixedPointVolumeRayCastCompositeGOHelper.MRClassNameKey = "class vtkFixedPointVolumeRayCastCompositeGOHelper";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkFixedPointVolumeRayCastCompositeGOHelper.MRClassNameKey, Type.GetType("Kitware.VTK.vtkFixedPointVolumeRayCastCompositeGOHelper"));
		}

		public vtkFixedPointVolumeRayCastCompositeGOHelper(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkFixedPointVolumeRayCastCompositeGOHelper_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkFixedPointVolumeRayCastCompositeGOHelper New()
		{
			vtkFixedPointVolumeRayCastCompositeGOHelper result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkFixedPointVolumeRayCastCompositeGOHelper.vtkFixedPointVolumeRayCastCompositeGOHelper_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkFixedPointVolumeRayCastCompositeGOHelper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkFixedPointVolumeRayCastCompositeGOHelper() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkFixedPointVolumeRayCastCompositeGOHelper.vtkFixedPointVolumeRayCastCompositeGOHelper_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkFixedPointVolumeRayCastCompositeGOHelper_GenerateImage_01(HandleRef pThis, int threadID, int threadCount, HandleRef vol, HandleRef mapper);

		public override void GenerateImage(int threadID, int threadCount, vtkVolume vol, vtkFixedPointVolumeRayCastMapper mapper)
		{
			vtkFixedPointVolumeRayCastCompositeGOHelper.vtkFixedPointVolumeRayCastCompositeGOHelper_GenerateImage_01(base.GetCppThis(), threadID, threadCount, (vol == null) ? default(HandleRef) : vol.GetCppThis(), (mapper == null) ? default(HandleRef) : mapper.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkFixedPointVolumeRayCastCompositeGOHelper_IsA_02(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkFixedPointVolumeRayCastCompositeGOHelper.vtkFixedPointVolumeRayCastCompositeGOHelper_IsA_02(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkFixedPointVolumeRayCastCompositeGOHelper_IsTypeOf_03(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkFixedPointVolumeRayCastCompositeGOHelper.vtkFixedPointVolumeRayCastCompositeGOHelper_IsTypeOf_03(type);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkFixedPointVolumeRayCastCompositeGOHelper_NewInstance_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkFixedPointVolumeRayCastCompositeGOHelper NewInstance()
		{
			vtkFixedPointVolumeRayCastCompositeGOHelper result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkFixedPointVolumeRayCastCompositeGOHelper.vtkFixedPointVolumeRayCastCompositeGOHelper_NewInstance_05(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkFixedPointVolumeRayCastCompositeGOHelper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkFixedPointVolumeRayCastCompositeGOHelper_SafeDownCast_06(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkFixedPointVolumeRayCastCompositeGOHelper SafeDownCast(vtkObjectBase o)
		{
			vtkFixedPointVolumeRayCastCompositeGOHelper vtkFixedPointVolumeRayCastCompositeGOHelper = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkFixedPointVolumeRayCastCompositeGOHelper.vtkFixedPointVolumeRayCastCompositeGOHelper_SafeDownCast_06((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkFixedPointVolumeRayCastCompositeGOHelper = (vtkFixedPointVolumeRayCastCompositeGOHelper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkFixedPointVolumeRayCastCompositeGOHelper.Register(null);
				}
			}
			return vtkFixedPointVolumeRayCastCompositeGOHelper;
		}
	}
}
