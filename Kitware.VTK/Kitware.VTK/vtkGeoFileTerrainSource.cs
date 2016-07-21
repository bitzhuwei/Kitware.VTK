using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkGeoFileTerrainSource : vtkGeoSource
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkGeoFileTerrainSource";

		public new static readonly string MRClassNameKey;

		static vtkGeoFileTerrainSource()
		{
			vtkGeoFileTerrainSource.MRClassNameKey = "class vtkGeoFileTerrainSource";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkGeoFileTerrainSource.MRClassNameKey, Type.GetType("Kitware.VTK.vtkGeoFileTerrainSource"));
		}

		public vtkGeoFileTerrainSource(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern IntPtr vtkGeoFileTerrainSource_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkGeoFileTerrainSource New()
		{
			vtkGeoFileTerrainSource result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGeoFileTerrainSource.vtkGeoFileTerrainSource_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGeoFileTerrainSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkGeoFileTerrainSource() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkGeoFileTerrainSource.vtkGeoFileTerrainSource_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern byte vtkGeoFileTerrainSource_FetchChild_01(HandleRef pThis, HandleRef node, int index, HandleRef child);

		public override bool FetchChild(vtkGeoTreeNode node, int index, vtkGeoTreeNode child)
		{
			return vtkGeoFileTerrainSource.vtkGeoFileTerrainSource_FetchChild_01(base.GetCppThis(), (node == null) ? default(HandleRef) : node.GetCppThis(), index, (child == null) ? default(HandleRef) : child.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern byte vtkGeoFileTerrainSource_FetchRoot_02(HandleRef pThis, HandleRef root);

		public override bool FetchRoot(vtkGeoTreeNode root)
		{
			return vtkGeoFileTerrainSource.vtkGeoFileTerrainSource_FetchRoot_02(base.GetCppThis(), (root == null) ? default(HandleRef) : root.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern IntPtr vtkGeoFileTerrainSource_GetPath_03(HandleRef pThis);

		public virtual string GetPath()
		{
			return Marshal.PtrToStringAnsi(vtkGeoFileTerrainSource.vtkGeoFileTerrainSource_GetPath_03(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern int vtkGeoFileTerrainSource_IsA_04(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkGeoFileTerrainSource.vtkGeoFileTerrainSource_IsA_04(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern int vtkGeoFileTerrainSource_IsTypeOf_05(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkGeoFileTerrainSource.vtkGeoFileTerrainSource_IsTypeOf_05(type);
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern IntPtr vtkGeoFileTerrainSource_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkGeoFileTerrainSource NewInstance()
		{
			vtkGeoFileTerrainSource result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGeoFileTerrainSource.vtkGeoFileTerrainSource_NewInstance_07(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGeoFileTerrainSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern IntPtr vtkGeoFileTerrainSource_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkGeoFileTerrainSource SafeDownCast(vtkObjectBase o)
		{
			vtkGeoFileTerrainSource vtkGeoFileTerrainSource = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGeoFileTerrainSource.vtkGeoFileTerrainSource_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGeoFileTerrainSource = (vtkGeoFileTerrainSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGeoFileTerrainSource.Register(null);
				}
			}
			return vtkGeoFileTerrainSource;
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern void vtkGeoFileTerrainSource_SetPath_09(HandleRef pThis, string _arg);

		public virtual void SetPath(string _arg)
		{
			vtkGeoFileTerrainSource.vtkGeoFileTerrainSource_SetPath_09(base.GetCppThis(), _arg);
		}
	}
}
