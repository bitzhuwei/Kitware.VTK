using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public abstract class vtkVolumeRayCastFunction : vtkObject
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkVolumeRayCastFunction";

		public new static readonly string MRClassNameKey;

		static vtkVolumeRayCastFunction()
		{
			vtkVolumeRayCastFunction.MRClassNameKey = "class vtkVolumeRayCastFunction";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkVolumeRayCastFunction.MRClassNameKey, Type.GetType("Kitware.VTK.vtkVolumeRayCastFunction"));
		}

		public vtkVolumeRayCastFunction(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern float vtkVolumeRayCastFunction_GetZeroOpacityThreshold_01(HandleRef pThis, HandleRef vol);

		public virtual float GetZeroOpacityThreshold(vtkVolume vol)
		{
			return vtkVolumeRayCastFunction.vtkVolumeRayCastFunction_GetZeroOpacityThreshold_01(base.GetCppThis(), (vol == null) ? default(HandleRef) : vol.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkVolumeRayCastFunction_IsA_02(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkVolumeRayCastFunction.vtkVolumeRayCastFunction_IsA_02(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkVolumeRayCastFunction_IsTypeOf_03(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkVolumeRayCastFunction.vtkVolumeRayCastFunction_IsTypeOf_03(type);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkVolumeRayCastFunction_NewInstance_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkVolumeRayCastFunction NewInstance()
		{
			vtkVolumeRayCastFunction result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkVolumeRayCastFunction.vtkVolumeRayCastFunction_NewInstance_04(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkVolumeRayCastFunction)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkVolumeRayCastFunction_SafeDownCast_05(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkVolumeRayCastFunction SafeDownCast(vtkObjectBase o)
		{
			vtkVolumeRayCastFunction vtkVolumeRayCastFunction = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkVolumeRayCastFunction.vtkVolumeRayCastFunction_SafeDownCast_05((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkVolumeRayCastFunction = (vtkVolumeRayCastFunction)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkVolumeRayCastFunction.Register(null);
				}
			}
			return vtkVolumeRayCastFunction;
		}
	}
}
