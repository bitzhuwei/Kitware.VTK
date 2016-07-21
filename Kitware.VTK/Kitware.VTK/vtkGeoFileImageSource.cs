using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkGeoFileImageSource : vtkGeoSource
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkGeoFileImageSource";

		public new static readonly string MRClassNameKey;

		static vtkGeoFileImageSource()
		{
			vtkGeoFileImageSource.MRClassNameKey = "class vtkGeoFileImageSource";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkGeoFileImageSource.MRClassNameKey, Type.GetType("Kitware.VTK.vtkGeoFileImageSource"));
		}

		public vtkGeoFileImageSource(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern IntPtr vtkGeoFileImageSource_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkGeoFileImageSource New()
		{
			vtkGeoFileImageSource result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGeoFileImageSource.vtkGeoFileImageSource_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGeoFileImageSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkGeoFileImageSource() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkGeoFileImageSource.vtkGeoFileImageSource_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern byte vtkGeoFileImageSource_FetchChild_01(HandleRef pThis, HandleRef node, int index, HandleRef child);

		public override bool FetchChild(vtkGeoTreeNode node, int index, vtkGeoTreeNode child)
		{
			return vtkGeoFileImageSource.vtkGeoFileImageSource_FetchChild_01(base.GetCppThis(), (node == null) ? default(HandleRef) : node.GetCppThis(), index, (child == null) ? default(HandleRef) : child.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern byte vtkGeoFileImageSource_FetchRoot_02(HandleRef pThis, HandleRef root);

		public override bool FetchRoot(vtkGeoTreeNode root)
		{
			return vtkGeoFileImageSource.vtkGeoFileImageSource_FetchRoot_02(base.GetCppThis(), (root == null) ? default(HandleRef) : root.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern IntPtr vtkGeoFileImageSource_GetPath_03(HandleRef pThis);

		public virtual string GetPath()
		{
			return Marshal.PtrToStringAnsi(vtkGeoFileImageSource.vtkGeoFileImageSource_GetPath_03(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern int vtkGeoFileImageSource_IsA_04(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkGeoFileImageSource.vtkGeoFileImageSource_IsA_04(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern int vtkGeoFileImageSource_IsTypeOf_05(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkGeoFileImageSource.vtkGeoFileImageSource_IsTypeOf_05(type);
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern IntPtr vtkGeoFileImageSource_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkGeoFileImageSource NewInstance()
		{
			vtkGeoFileImageSource result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGeoFileImageSource.vtkGeoFileImageSource_NewInstance_07(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGeoFileImageSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern IntPtr vtkGeoFileImageSource_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkGeoFileImageSource SafeDownCast(vtkObjectBase o)
		{
			vtkGeoFileImageSource vtkGeoFileImageSource = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGeoFileImageSource.vtkGeoFileImageSource_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGeoFileImageSource = (vtkGeoFileImageSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGeoFileImageSource.Register(null);
				}
			}
			return vtkGeoFileImageSource;
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern void vtkGeoFileImageSource_SetPath_09(HandleRef pThis, string _arg);

		public virtual void SetPath(string _arg)
		{
			vtkGeoFileImageSource.vtkGeoFileImageSource_SetPath_09(base.GetCppThis(), _arg);
		}
	}
}
