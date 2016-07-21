using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkGraphToPolyData : vtkPolyDataAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkGraphToPolyData";

		public new static readonly string MRClassNameKey;

		static vtkGraphToPolyData()
		{
			vtkGraphToPolyData.MRClassNameKey = "class vtkGraphToPolyData";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkGraphToPolyData.MRClassNameKey, Type.GetType("Kitware.VTK.vtkGraphToPolyData"));
		}

		public vtkGraphToPolyData(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkGraphToPolyData_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkGraphToPolyData New()
		{
			vtkGraphToPolyData result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGraphToPolyData.vtkGraphToPolyData_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGraphToPolyData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkGraphToPolyData() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkGraphToPolyData.vtkGraphToPolyData_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkGraphToPolyData_EdgeGlyphOutputOff_01(HandleRef pThis);

		public virtual void EdgeGlyphOutputOff()
		{
			vtkGraphToPolyData.vtkGraphToPolyData_EdgeGlyphOutputOff_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkGraphToPolyData_EdgeGlyphOutputOn_02(HandleRef pThis);

		public virtual void EdgeGlyphOutputOn()
		{
			vtkGraphToPolyData.vtkGraphToPolyData_EdgeGlyphOutputOn_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern byte vtkGraphToPolyData_GetEdgeGlyphOutput_03(HandleRef pThis);

		public virtual bool GetEdgeGlyphOutput()
		{
			return vtkGraphToPolyData.vtkGraphToPolyData_GetEdgeGlyphOutput_03(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkGraphToPolyData_GetEdgeGlyphPosition_04(HandleRef pThis);

		public virtual double GetEdgeGlyphPosition()
		{
			return vtkGraphToPolyData.vtkGraphToPolyData_GetEdgeGlyphPosition_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkGraphToPolyData_IsA_05(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkGraphToPolyData.vtkGraphToPolyData_IsA_05(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkGraphToPolyData_IsTypeOf_06(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkGraphToPolyData.vtkGraphToPolyData_IsTypeOf_06(type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkGraphToPolyData_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkGraphToPolyData NewInstance()
		{
			vtkGraphToPolyData result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGraphToPolyData.vtkGraphToPolyData_NewInstance_08(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGraphToPolyData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkGraphToPolyData_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkGraphToPolyData SafeDownCast(vtkObjectBase o)
		{
			vtkGraphToPolyData vtkGraphToPolyData = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGraphToPolyData.vtkGraphToPolyData_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGraphToPolyData = (vtkGraphToPolyData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGraphToPolyData.Register(null);
				}
			}
			return vtkGraphToPolyData;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkGraphToPolyData_SetEdgeGlyphOutput_10(HandleRef pThis, byte _arg);

		public virtual void SetEdgeGlyphOutput(bool _arg)
		{
			vtkGraphToPolyData.vtkGraphToPolyData_SetEdgeGlyphOutput_10(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkGraphToPolyData_SetEdgeGlyphPosition_11(HandleRef pThis, double _arg);

		public virtual void SetEdgeGlyphPosition(double _arg)
		{
			vtkGraphToPolyData.vtkGraphToPolyData_SetEdgeGlyphPosition_11(base.GetCppThis(), _arg);
		}
	}
}
