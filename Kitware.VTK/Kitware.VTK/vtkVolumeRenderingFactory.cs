using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkVolumeRenderingFactory : vtkObject
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkVolumeRenderingFactory";

		public new static readonly string MRClassNameKey;

		static vtkVolumeRenderingFactory()
		{
			vtkVolumeRenderingFactory.MRClassNameKey = "class vtkVolumeRenderingFactory";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkVolumeRenderingFactory.MRClassNameKey, Type.GetType("Kitware.VTK.vtkVolumeRenderingFactory"));
		}

		public vtkVolumeRenderingFactory(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkVolumeRenderingFactory_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkVolumeRenderingFactory New()
		{
			vtkVolumeRenderingFactory result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkVolumeRenderingFactory.vtkVolumeRenderingFactory_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkVolumeRenderingFactory)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkVolumeRenderingFactory() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkVolumeRenderingFactory.vtkVolumeRenderingFactory_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkVolumeRenderingFactory_CreateInstance_01(string vtkclassname, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public static vtkObject CreateInstance(string vtkclassname)
		{
			vtkObject result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkVolumeRenderingFactory.vtkVolumeRenderingFactory_CreateInstance_01(vtkclassname, ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkObject)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkVolumeRenderingFactory_IsA_02(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkVolumeRenderingFactory.vtkVolumeRenderingFactory_IsA_02(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkVolumeRenderingFactory_IsTypeOf_03(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkVolumeRenderingFactory.vtkVolumeRenderingFactory_IsTypeOf_03(type);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkVolumeRenderingFactory_NewInstance_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkVolumeRenderingFactory NewInstance()
		{
			vtkVolumeRenderingFactory result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkVolumeRenderingFactory.vtkVolumeRenderingFactory_NewInstance_05(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkVolumeRenderingFactory)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkVolumeRenderingFactory_SafeDownCast_06(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkVolumeRenderingFactory SafeDownCast(vtkObjectBase o)
		{
			vtkVolumeRenderingFactory vtkVolumeRenderingFactory = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkVolumeRenderingFactory.vtkVolumeRenderingFactory_SafeDownCast_06((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkVolumeRenderingFactory = (vtkVolumeRenderingFactory)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkVolumeRenderingFactory.Register(null);
				}
			}
			return vtkVolumeRenderingFactory;
		}
	}
}
