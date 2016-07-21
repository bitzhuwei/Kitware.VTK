using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkTDxInteractorStyleGeo : vtkTDxInteractorStyle
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkTDxInteractorStyleGeo";

		public new static readonly string MRClassNameKey;

		static vtkTDxInteractorStyleGeo()
		{
			vtkTDxInteractorStyleGeo.MRClassNameKey = "class vtkTDxInteractorStyleGeo";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkTDxInteractorStyleGeo.MRClassNameKey, Type.GetType("Kitware.VTK.vtkTDxInteractorStyleGeo"));
		}

		public vtkTDxInteractorStyleGeo(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkTDxInteractorStyleGeo_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkTDxInteractorStyleGeo New()
		{
			vtkTDxInteractorStyleGeo result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTDxInteractorStyleGeo.vtkTDxInteractorStyleGeo_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTDxInteractorStyleGeo)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkTDxInteractorStyleGeo() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkTDxInteractorStyleGeo.vtkTDxInteractorStyleGeo_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkTDxInteractorStyleGeo_IsA_01(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkTDxInteractorStyleGeo.vtkTDxInteractorStyleGeo_IsA_01(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkTDxInteractorStyleGeo_IsTypeOf_02(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkTDxInteractorStyleGeo.vtkTDxInteractorStyleGeo_IsTypeOf_02(type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkTDxInteractorStyleGeo_NewInstance_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkTDxInteractorStyleGeo NewInstance()
		{
			vtkTDxInteractorStyleGeo result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTDxInteractorStyleGeo.vtkTDxInteractorStyleGeo_NewInstance_04(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTDxInteractorStyleGeo)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkTDxInteractorStyleGeo_SafeDownCast_05(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkTDxInteractorStyleGeo SafeDownCast(vtkObjectBase o)
		{
			vtkTDxInteractorStyleGeo vtkTDxInteractorStyleGeo = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTDxInteractorStyleGeo.vtkTDxInteractorStyleGeo_SafeDownCast_05((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTDxInteractorStyleGeo = (vtkTDxInteractorStyleGeo)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTDxInteractorStyleGeo.Register(null);
				}
			}
			return vtkTDxInteractorStyleGeo;
		}
	}
}
