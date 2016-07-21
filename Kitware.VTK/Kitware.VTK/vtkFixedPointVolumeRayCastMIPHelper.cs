using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkFixedPointVolumeRayCastMIPHelper : vtkFixedPointVolumeRayCastHelper
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkFixedPointVolumeRayCastMIPHelper";

		public new static readonly string MRClassNameKey;

		static vtkFixedPointVolumeRayCastMIPHelper()
		{
			vtkFixedPointVolumeRayCastMIPHelper.MRClassNameKey = "class vtkFixedPointVolumeRayCastMIPHelper";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkFixedPointVolumeRayCastMIPHelper.MRClassNameKey, Type.GetType("Kitware.VTK.vtkFixedPointVolumeRayCastMIPHelper"));
		}

		public vtkFixedPointVolumeRayCastMIPHelper(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkFixedPointVolumeRayCastMIPHelper_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkFixedPointVolumeRayCastMIPHelper New()
		{
			vtkFixedPointVolumeRayCastMIPHelper result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkFixedPointVolumeRayCastMIPHelper.vtkFixedPointVolumeRayCastMIPHelper_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkFixedPointVolumeRayCastMIPHelper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkFixedPointVolumeRayCastMIPHelper() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkFixedPointVolumeRayCastMIPHelper.vtkFixedPointVolumeRayCastMIPHelper_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkFixedPointVolumeRayCastMIPHelper_GenerateImage_01(HandleRef pThis, int threadID, int threadCount, HandleRef vol, HandleRef mapper);

		public override void GenerateImage(int threadID, int threadCount, vtkVolume vol, vtkFixedPointVolumeRayCastMapper mapper)
		{
			vtkFixedPointVolumeRayCastMIPHelper.vtkFixedPointVolumeRayCastMIPHelper_GenerateImage_01(base.GetCppThis(), threadID, threadCount, (vol == null) ? default(HandleRef) : vol.GetCppThis(), (mapper == null) ? default(HandleRef) : mapper.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkFixedPointVolumeRayCastMIPHelper_IsA_02(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkFixedPointVolumeRayCastMIPHelper.vtkFixedPointVolumeRayCastMIPHelper_IsA_02(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkFixedPointVolumeRayCastMIPHelper_IsTypeOf_03(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkFixedPointVolumeRayCastMIPHelper.vtkFixedPointVolumeRayCastMIPHelper_IsTypeOf_03(type);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkFixedPointVolumeRayCastMIPHelper_NewInstance_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkFixedPointVolumeRayCastMIPHelper NewInstance()
		{
			vtkFixedPointVolumeRayCastMIPHelper result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkFixedPointVolumeRayCastMIPHelper.vtkFixedPointVolumeRayCastMIPHelper_NewInstance_05(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkFixedPointVolumeRayCastMIPHelper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkFixedPointVolumeRayCastMIPHelper_SafeDownCast_06(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkFixedPointVolumeRayCastMIPHelper SafeDownCast(vtkObjectBase o)
		{
			vtkFixedPointVolumeRayCastMIPHelper vtkFixedPointVolumeRayCastMIPHelper = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkFixedPointVolumeRayCastMIPHelper.vtkFixedPointVolumeRayCastMIPHelper_SafeDownCast_06((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkFixedPointVolumeRayCastMIPHelper = (vtkFixedPointVolumeRayCastMIPHelper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkFixedPointVolumeRayCastMIPHelper.Register(null);
				}
			}
			return vtkFixedPointVolumeRayCastMIPHelper;
		}
	}
}
