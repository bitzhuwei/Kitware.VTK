using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkExtractLevel : vtkHierarchicalBoxDataSetAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkExtractLevel";

		public new static readonly string MRClassNameKey;

		static vtkExtractLevel()
		{
			vtkExtractLevel.MRClassNameKey = "class vtkExtractLevel";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkExtractLevel.MRClassNameKey, Type.GetType("Kitware.VTK.vtkExtractLevel"));
		}

		public vtkExtractLevel(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkExtractLevel_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkExtractLevel New()
		{
			vtkExtractLevel result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkExtractLevel.vtkExtractLevel_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkExtractLevel)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkExtractLevel() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkExtractLevel.vtkExtractLevel_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkExtractLevel_AddLevel_01(HandleRef pThis, uint level);

		public void AddLevel(uint level)
		{
			vtkExtractLevel.vtkExtractLevel_AddLevel_01(base.GetCppThis(), level);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkExtractLevel_IsA_02(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkExtractLevel.vtkExtractLevel_IsA_02(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkExtractLevel_IsTypeOf_03(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkExtractLevel.vtkExtractLevel_IsTypeOf_03(type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkExtractLevel_NewInstance_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkExtractLevel NewInstance()
		{
			vtkExtractLevel result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkExtractLevel.vtkExtractLevel_NewInstance_05(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkExtractLevel)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkExtractLevel_RemoveAllLevels_06(HandleRef pThis);

		public void RemoveAllLevels()
		{
			vtkExtractLevel.vtkExtractLevel_RemoveAllLevels_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkExtractLevel_RemoveLevel_07(HandleRef pThis, uint level);

		public void RemoveLevel(uint level)
		{
			vtkExtractLevel.vtkExtractLevel_RemoveLevel_07(base.GetCppThis(), level);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkExtractLevel_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkExtractLevel SafeDownCast(vtkObjectBase o)
		{
			vtkExtractLevel vtkExtractLevel = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkExtractLevel.vtkExtractLevel_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkExtractLevel = (vtkExtractLevel)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkExtractLevel.Register(null);
				}
			}
			return vtkExtractLevel;
		}
	}
}
