using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkNetworkHierarchy : vtkTreeAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkNetworkHierarchy";

		public new static readonly string MRClassNameKey;

		static vtkNetworkHierarchy()
		{
			vtkNetworkHierarchy.MRClassNameKey = "class vtkNetworkHierarchy";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkNetworkHierarchy.MRClassNameKey, Type.GetType("Kitware.VTK.vtkNetworkHierarchy"));
		}

		public vtkNetworkHierarchy(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkNetworkHierarchy_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkNetworkHierarchy New()
		{
			vtkNetworkHierarchy result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkNetworkHierarchy.vtkNetworkHierarchy_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkNetworkHierarchy)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkNetworkHierarchy() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkNetworkHierarchy.vtkNetworkHierarchy_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkNetworkHierarchy_GetIPArrayName_01(HandleRef pThis);

		public virtual string GetIPArrayName()
		{
			return Marshal.PtrToStringAnsi(vtkNetworkHierarchy.vtkNetworkHierarchy_GetIPArrayName_01(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkNetworkHierarchy_IsA_02(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkNetworkHierarchy.vtkNetworkHierarchy_IsA_02(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkNetworkHierarchy_IsTypeOf_03(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkNetworkHierarchy.vtkNetworkHierarchy_IsTypeOf_03(type);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkNetworkHierarchy_NewInstance_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkNetworkHierarchy NewInstance()
		{
			vtkNetworkHierarchy result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkNetworkHierarchy.vtkNetworkHierarchy_NewInstance_05(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkNetworkHierarchy)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkNetworkHierarchy_SafeDownCast_06(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkNetworkHierarchy SafeDownCast(vtkObjectBase o)
		{
			vtkNetworkHierarchy vtkNetworkHierarchy = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkNetworkHierarchy.vtkNetworkHierarchy_SafeDownCast_06((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkNetworkHierarchy = (vtkNetworkHierarchy)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkNetworkHierarchy.Register(null);
				}
			}
			return vtkNetworkHierarchy;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkNetworkHierarchy_SetIPArrayName_07(HandleRef pThis, string _arg);

		public virtual void SetIPArrayName(string _arg)
		{
			vtkNetworkHierarchy.vtkNetworkHierarchy_SetIPArrayName_07(base.GetCppThis(), _arg);
		}
	}
}
