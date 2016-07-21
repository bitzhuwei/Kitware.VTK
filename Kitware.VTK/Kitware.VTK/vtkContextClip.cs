using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkContextClip : vtkAbstractContextItem
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkContextClip";

		public new static readonly string MRClassNameKey;

		static vtkContextClip()
		{
			vtkContextClip.MRClassNameKey = "class vtkContextClip";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkContextClip.MRClassNameKey, Type.GetType("Kitware.VTK.vtkContextClip"));
		}

		public vtkContextClip(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern IntPtr vtkContextClip_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkContextClip New()
		{
			vtkContextClip result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkContextClip.vtkContextClip_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkContextClip)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkContextClip() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkContextClip.vtkContextClip_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern int vtkContextClip_IsA_01(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkContextClip.vtkContextClip_IsA_01(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern int vtkContextClip_IsTypeOf_02(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkContextClip.vtkContextClip_IsTypeOf_02(type);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern IntPtr vtkContextClip_NewInstance_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkContextClip NewInstance()
		{
			vtkContextClip result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkContextClip.vtkContextClip_NewInstance_04(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkContextClip)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern byte vtkContextClip_Paint_05(HandleRef pThis, HandleRef painter);

		public override bool Paint(vtkContext2D painter)
		{
			return vtkContextClip.vtkContextClip_Paint_05(base.GetCppThis(), (painter == null) ? default(HandleRef) : painter.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern IntPtr vtkContextClip_SafeDownCast_06(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkContextClip SafeDownCast(vtkObjectBase o)
		{
			vtkContextClip vtkContextClip = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkContextClip.vtkContextClip_SafeDownCast_06((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkContextClip = (vtkContextClip)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkContextClip.Register(null);
				}
			}
			return vtkContextClip;
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkContextClip_SetClip_07(HandleRef pThis, float x, float y, float width, float height);

		public virtual void SetClip(float x, float y, float width, float height)
		{
			vtkContextClip.vtkContextClip_SetClip_07(base.GetCppThis(), x, y, width, height);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkContextClip_Update_08(HandleRef pThis);

		public override void Update()
		{
			vtkContextClip.vtkContextClip_Update_08(base.GetCppThis());
		}
	}
}
