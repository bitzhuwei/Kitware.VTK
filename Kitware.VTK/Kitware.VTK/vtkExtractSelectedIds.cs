using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkExtractSelectedIds : vtkExtractSelectionBase
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkExtractSelectedIds";

		public new static readonly string MRClassNameKey;

		static vtkExtractSelectedIds()
		{
			vtkExtractSelectedIds.MRClassNameKey = "class vtkExtractSelectedIds";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkExtractSelectedIds.MRClassNameKey, Type.GetType("Kitware.VTK.vtkExtractSelectedIds"));
		}

		public vtkExtractSelectedIds(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkExtractSelectedIds_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkExtractSelectedIds New()
		{
			vtkExtractSelectedIds result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkExtractSelectedIds.vtkExtractSelectedIds_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkExtractSelectedIds)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkExtractSelectedIds() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkExtractSelectedIds.vtkExtractSelectedIds_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkExtractSelectedIds_IsA_01(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkExtractSelectedIds.vtkExtractSelectedIds_IsA_01(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkExtractSelectedIds_IsTypeOf_02(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkExtractSelectedIds.vtkExtractSelectedIds_IsTypeOf_02(type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkExtractSelectedIds_NewInstance_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkExtractSelectedIds NewInstance()
		{
			vtkExtractSelectedIds result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkExtractSelectedIds.vtkExtractSelectedIds_NewInstance_04(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkExtractSelectedIds)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkExtractSelectedIds_SafeDownCast_05(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkExtractSelectedIds SafeDownCast(vtkObjectBase o)
		{
			vtkExtractSelectedIds vtkExtractSelectedIds = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkExtractSelectedIds.vtkExtractSelectedIds_SafeDownCast_05((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkExtractSelectedIds = (vtkExtractSelectedIds)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkExtractSelectedIds.Register(null);
				}
			}
			return vtkExtractSelectedIds;
		}
	}
}
