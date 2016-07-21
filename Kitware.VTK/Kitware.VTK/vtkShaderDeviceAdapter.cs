using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public abstract class vtkShaderDeviceAdapter : vtkObject
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkShaderDeviceAdapter";

		public new static readonly string MRClassNameKey;

		static vtkShaderDeviceAdapter()
		{
			vtkShaderDeviceAdapter.MRClassNameKey = "class vtkShaderDeviceAdapter";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkShaderDeviceAdapter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkShaderDeviceAdapter"));
		}

		public vtkShaderDeviceAdapter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkShaderDeviceAdapter_GetShaderProgram_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkShaderProgram GetShaderProgram()
		{
			vtkShaderProgram vtkShaderProgram = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkShaderDeviceAdapter.vtkShaderDeviceAdapter_GetShaderProgram_01(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkShaderProgram = (vtkShaderProgram)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkShaderProgram.Register(null);
				}
			}
			return vtkShaderProgram;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkShaderDeviceAdapter_IsA_02(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkShaderDeviceAdapter.vtkShaderDeviceAdapter_IsA_02(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkShaderDeviceAdapter_IsTypeOf_03(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkShaderDeviceAdapter.vtkShaderDeviceAdapter_IsTypeOf_03(type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkShaderDeviceAdapter_NewInstance_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkShaderDeviceAdapter NewInstance()
		{
			vtkShaderDeviceAdapter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkShaderDeviceAdapter.vtkShaderDeviceAdapter_NewInstance_04(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkShaderDeviceAdapter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkShaderDeviceAdapter_PrepareForRender_05(HandleRef pThis);

		public virtual void PrepareForRender()
		{
			vtkShaderDeviceAdapter.vtkShaderDeviceAdapter_PrepareForRender_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkShaderDeviceAdapter_SafeDownCast_06(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkShaderDeviceAdapter SafeDownCast(vtkObjectBase o)
		{
			vtkShaderDeviceAdapter vtkShaderDeviceAdapter = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkShaderDeviceAdapter.vtkShaderDeviceAdapter_SafeDownCast_06((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkShaderDeviceAdapter = (vtkShaderDeviceAdapter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkShaderDeviceAdapter.Register(null);
				}
			}
			return vtkShaderDeviceAdapter;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkShaderDeviceAdapter_SendAttribute_07(HandleRef pThis, string attrname, int components, int type, IntPtr attribute, uint offset);

		public virtual void SendAttribute(string attrname, int components, int type, IntPtr attribute, uint offset)
		{
			vtkShaderDeviceAdapter.vtkShaderDeviceAdapter_SendAttribute_07(base.GetCppThis(), attrname, components, type, attribute, offset);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkShaderDeviceAdapter_SetShaderProgram_08(HandleRef pThis, HandleRef pgm);

		public void SetShaderProgram(vtkShaderProgram pgm)
		{
			vtkShaderDeviceAdapter.vtkShaderDeviceAdapter_SetShaderProgram_08(base.GetCppThis(), (pgm == null) ? default(HandleRef) : pgm.GetCppThis());
		}
	}
}
