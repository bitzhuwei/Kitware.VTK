using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkAssemblyPaths : vtkCollection
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkAssemblyPaths";

		public new static readonly string MRClassNameKey;

		static vtkAssemblyPaths()
		{
			vtkAssemblyPaths.MRClassNameKey = "class vtkAssemblyPaths";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkAssemblyPaths.MRClassNameKey, Type.GetType("Kitware.VTK.vtkAssemblyPaths"));
		}

		public vtkAssemblyPaths(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkAssemblyPaths_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkAssemblyPaths New()
		{
			vtkAssemblyPaths result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAssemblyPaths.vtkAssemblyPaths_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAssemblyPaths)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkAssemblyPaths() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkAssemblyPaths.vtkAssemblyPaths_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkAssemblyPaths_AddItem_01(HandleRef pThis, HandleRef p);

		public void AddItem(vtkAssemblyPath p)
		{
			vtkAssemblyPaths.vtkAssemblyPaths_AddItem_01(base.GetCppThis(), (p == null) ? default(HandleRef) : p.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern uint vtkAssemblyPaths_GetMTime_02(HandleRef pThis);

		public override uint GetMTime()
		{
			return vtkAssemblyPaths.vtkAssemblyPaths_GetMTime_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkAssemblyPaths_GetNextItem_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkAssemblyPath GetNextItem()
		{
			vtkAssemblyPath vtkAssemblyPath = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAssemblyPaths.vtkAssemblyPaths_GetNextItem_03(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAssemblyPath = (vtkAssemblyPath)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAssemblyPath.Register(null);
				}
			}
			return vtkAssemblyPath;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkAssemblyPaths_IsA_04(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkAssemblyPaths.vtkAssemblyPaths_IsA_04(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkAssemblyPaths_IsItemPresent_05(HandleRef pThis, HandleRef p);

		public int IsItemPresent(vtkAssemblyPath p)
		{
			return vtkAssemblyPaths.vtkAssemblyPaths_IsItemPresent_05(base.GetCppThis(), (p == null) ? default(HandleRef) : p.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkAssemblyPaths_IsTypeOf_06(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkAssemblyPaths.vtkAssemblyPaths_IsTypeOf_06(type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkAssemblyPaths_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkAssemblyPaths NewInstance()
		{
			vtkAssemblyPaths result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAssemblyPaths.vtkAssemblyPaths_NewInstance_08(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAssemblyPaths)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkAssemblyPaths_RemoveItem_09(HandleRef pThis, HandleRef p);

		public void RemoveItem(vtkAssemblyPath p)
		{
			vtkAssemblyPaths.vtkAssemblyPaths_RemoveItem_09(base.GetCppThis(), (p == null) ? default(HandleRef) : p.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkAssemblyPaths_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkAssemblyPaths SafeDownCast(vtkObjectBase o)
		{
			vtkAssemblyPaths vtkAssemblyPaths = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAssemblyPaths.vtkAssemblyPaths_SafeDownCast_10((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAssemblyPaths = (vtkAssemblyPaths)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAssemblyPaths.Register(null);
				}
			}
			return vtkAssemblyPaths;
		}
	}
}
