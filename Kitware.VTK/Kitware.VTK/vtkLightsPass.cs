using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkLightsPass : vtkRenderPass
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkLightsPass";

		public new static readonly string MRClassNameKey;

		static vtkLightsPass()
		{
			vtkLightsPass.MRClassNameKey = "class vtkLightsPass";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkLightsPass.MRClassNameKey, Type.GetType("Kitware.VTK.vtkLightsPass"));
		}

		public vtkLightsPass(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkLightsPass_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkLightsPass New()
		{
			vtkLightsPass result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkLightsPass.vtkLightsPass_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkLightsPass)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkLightsPass() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkLightsPass.vtkLightsPass_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkLightsPass_IsA_01(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkLightsPass.vtkLightsPass_IsA_01(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkLightsPass_IsTypeOf_02(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkLightsPass.vtkLightsPass_IsTypeOf_02(type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkLightsPass_NewInstance_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkLightsPass NewInstance()
		{
			vtkLightsPass result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkLightsPass.vtkLightsPass_NewInstance_04(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkLightsPass)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkLightsPass_SafeDownCast_05(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkLightsPass SafeDownCast(vtkObjectBase o)
		{
			vtkLightsPass vtkLightsPass = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkLightsPass.vtkLightsPass_SafeDownCast_05((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkLightsPass = (vtkLightsPass)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkLightsPass.Register(null);
				}
			}
			return vtkLightsPass;
		}
	}
}
