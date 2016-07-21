using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkRIBLight : vtkLight
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkRIBLight";

		public new static readonly string MRClassNameKey;

		static vtkRIBLight()
		{
			vtkRIBLight.MRClassNameKey = "class vtkRIBLight";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkRIBLight.MRClassNameKey, Type.GetType("Kitware.VTK.vtkRIBLight"));
		}

		public vtkRIBLight(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkRIBLight_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkRIBLight New()
		{
			vtkRIBLight result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkRIBLight.vtkRIBLight_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkRIBLight)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkRIBLight() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkRIBLight.vtkRIBLight_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkRIBLight_GetShadows_01(HandleRef pThis);

		public virtual int GetShadows()
		{
			return vtkRIBLight.vtkRIBLight_GetShadows_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkRIBLight_IsA_02(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkRIBLight.vtkRIBLight_IsA_02(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkRIBLight_IsTypeOf_03(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkRIBLight.vtkRIBLight_IsTypeOf_03(type);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkRIBLight_NewInstance_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkRIBLight NewInstance()
		{
			vtkRIBLight result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkRIBLight.vtkRIBLight_NewInstance_05(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkRIBLight)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkRIBLight_Render_06(HandleRef pThis, HandleRef ren, int index);

		public override void Render(vtkRenderer ren, int index)
		{
			vtkRIBLight.vtkRIBLight_Render_06(base.GetCppThis(), (ren == null) ? default(HandleRef) : ren.GetCppThis(), index);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkRIBLight_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkRIBLight SafeDownCast(vtkObjectBase o)
		{
			vtkRIBLight vtkRIBLight = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkRIBLight.vtkRIBLight_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkRIBLight = (vtkRIBLight)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkRIBLight.Register(null);
				}
			}
			return vtkRIBLight;
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkRIBLight_SetShadows_08(HandleRef pThis, int _arg);

		public virtual void SetShadows(int _arg)
		{
			vtkRIBLight.vtkRIBLight_SetShadows_08(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkRIBLight_ShadowsOff_09(HandleRef pThis);

		public virtual void ShadowsOff()
		{
			vtkRIBLight.vtkRIBLight_ShadowsOff_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkRIBLight_ShadowsOn_10(HandleRef pThis);

		public virtual void ShadowsOn()
		{
			vtkRIBLight.vtkRIBLight_ShadowsOn_10(base.GetCppThis());
		}
	}
}
