using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkGeoGlobeSource : vtkGeoSource
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkGeoGlobeSource";

		public new static readonly string MRClassNameKey;

		static vtkGeoGlobeSource()
		{
			vtkGeoGlobeSource.MRClassNameKey = "class vtkGeoGlobeSource";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkGeoGlobeSource.MRClassNameKey, Type.GetType("Kitware.VTK.vtkGeoGlobeSource"));
		}

		public vtkGeoGlobeSource(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern IntPtr vtkGeoGlobeSource_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkGeoGlobeSource New()
		{
			vtkGeoGlobeSource result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGeoGlobeSource.vtkGeoGlobeSource_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGeoGlobeSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkGeoGlobeSource() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkGeoGlobeSource.vtkGeoGlobeSource_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern byte vtkGeoGlobeSource_FetchChild_01(HandleRef pThis, HandleRef node, int index, HandleRef child);

		public override bool FetchChild(vtkGeoTreeNode node, int index, vtkGeoTreeNode child)
		{
			return vtkGeoGlobeSource.vtkGeoGlobeSource_FetchChild_01(base.GetCppThis(), (node == null) ? default(HandleRef) : node.GetCppThis(), index, (child == null) ? default(HandleRef) : child.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern byte vtkGeoGlobeSource_FetchRoot_02(HandleRef pThis, HandleRef root);

		public override bool FetchRoot(vtkGeoTreeNode root)
		{
			return vtkGeoGlobeSource.vtkGeoGlobeSource_FetchRoot_02(base.GetCppThis(), (root == null) ? default(HandleRef) : root.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern int vtkGeoGlobeSource_IsA_03(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkGeoGlobeSource.vtkGeoGlobeSource_IsA_03(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern int vtkGeoGlobeSource_IsTypeOf_04(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkGeoGlobeSource.vtkGeoGlobeSource_IsTypeOf_04(type);
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern IntPtr vtkGeoGlobeSource_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkGeoGlobeSource NewInstance()
		{
			vtkGeoGlobeSource result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGeoGlobeSource.vtkGeoGlobeSource_NewInstance_06(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGeoGlobeSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern IntPtr vtkGeoGlobeSource_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkGeoGlobeSource SafeDownCast(vtkObjectBase o)
		{
			vtkGeoGlobeSource vtkGeoGlobeSource = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGeoGlobeSource.vtkGeoGlobeSource_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGeoGlobeSource = (vtkGeoGlobeSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGeoGlobeSource.Register(null);
				}
			}
			return vtkGeoGlobeSource;
		}
	}
}
