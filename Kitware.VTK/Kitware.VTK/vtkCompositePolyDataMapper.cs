using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkCompositePolyDataMapper : vtkMapper
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkCompositePolyDataMapper";

		public new static readonly string MRClassNameKey;

		static vtkCompositePolyDataMapper()
		{
			vtkCompositePolyDataMapper.MRClassNameKey = "class vtkCompositePolyDataMapper";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkCompositePolyDataMapper.MRClassNameKey, Type.GetType("Kitware.VTK.vtkCompositePolyDataMapper"));
		}

		public vtkCompositePolyDataMapper(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkCompositePolyDataMapper_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkCompositePolyDataMapper New()
		{
			vtkCompositePolyDataMapper result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCompositePolyDataMapper.vtkCompositePolyDataMapper_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCompositePolyDataMapper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkCompositePolyDataMapper() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkCompositePolyDataMapper.vtkCompositePolyDataMapper_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkCompositePolyDataMapper_GetBounds_01(HandleRef pThis);

		public override double[] GetBounds()
		{
			IntPtr intPtr = vtkCompositePolyDataMapper.vtkCompositePolyDataMapper_GetBounds_01(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkCompositePolyDataMapper_GetBounds_02(HandleRef pThis, IntPtr bounds);

		public override void GetBounds(IntPtr bounds)
		{
			vtkCompositePolyDataMapper.vtkCompositePolyDataMapper_GetBounds_02(base.GetCppThis(), bounds);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkCompositePolyDataMapper_IsA_03(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkCompositePolyDataMapper.vtkCompositePolyDataMapper_IsA_03(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkCompositePolyDataMapper_IsTypeOf_04(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkCompositePolyDataMapper.vtkCompositePolyDataMapper_IsTypeOf_04(type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkCompositePolyDataMapper_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkCompositePolyDataMapper NewInstance()
		{
			vtkCompositePolyDataMapper result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCompositePolyDataMapper.vtkCompositePolyDataMapper_NewInstance_06(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCompositePolyDataMapper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkCompositePolyDataMapper_ReleaseGraphicsResources_07(HandleRef pThis, HandleRef arg0);

		public override void ReleaseGraphicsResources(vtkWindow arg0)
		{
			vtkCompositePolyDataMapper.vtkCompositePolyDataMapper_ReleaseGraphicsResources_07(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkCompositePolyDataMapper_Render_08(HandleRef pThis, HandleRef ren, HandleRef a);

		public override void Render(vtkRenderer ren, vtkActor a)
		{
			vtkCompositePolyDataMapper.vtkCompositePolyDataMapper_Render_08(base.GetCppThis(), (ren == null) ? default(HandleRef) : ren.GetCppThis(), (a == null) ? default(HandleRef) : a.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkCompositePolyDataMapper_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkCompositePolyDataMapper SafeDownCast(vtkObjectBase o)
		{
			vtkCompositePolyDataMapper vtkCompositePolyDataMapper = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCompositePolyDataMapper.vtkCompositePolyDataMapper_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCompositePolyDataMapper = (vtkCompositePolyDataMapper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCompositePolyDataMapper.Register(null);
				}
			}
			return vtkCompositePolyDataMapper;
		}
	}
}
